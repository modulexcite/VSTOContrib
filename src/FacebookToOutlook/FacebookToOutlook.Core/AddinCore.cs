﻿using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Autofac;
using FacebookToOutlook.Data;
using FacebookToOutlook.Presentation;
using FacebookToOutlook.Services;
using log4net;
using log4net.Config;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Practices.ServiceLocation;
using Office.Utility;

namespace FacebookToOutlook
{
    public class AddinCore : IDisposable
    {
        private ContainerBuilder _builder;
        private IContainer _container;

        public AddinCore(NameSpace session)
        {
            if (System.Windows.Application.Current == null)
                new System.Windows.Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
            else
                System.Windows.Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            SetupIoC(session, Assembly.GetCallingAssembly());

            var deployment = new VstoClickOnceUpdater();
            deployment.CheckForUpdateAsync(r =>
                                               {
                                                   if (!r.Success || !r.Updated) return;
                                                   var ds = ServiceLocator.GetInstance<IDialogService>();
                                                   ds.ShowMessageBox(null, r.Message, "FacebookToOutlook Updated", MessageBoxButton.OK, MessageBoxImage.None);
                                               });
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public AutofacServiceLocator ServiceLocator { get; private set; }

        private void SetupIoC(NameSpace session, Assembly callingAssembly)
        {
            _builder = new ContainerBuilder();

            _builder.Register(c=>Dispatcher.CurrentDispatcher);
            _builder.Register(c => SetupLog()).As<ILog>();
            
            _builder.Register(c => session);
            _builder.RegisterType<FacebookEventSynchronisationService>().SingleInstance();

            _builder.Register(c => ServiceLocator).As<IServiceLocator>();

            _builder.RegisterModule(new SettingsModule());
            _builder.RegisterModule(new DataModule());
            _builder.RegisterModule(new ServicesModule());
            _builder.RegisterModule(new PresentationModule());

            _builder.RegisterAssemblyTypes(callingAssembly, Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
            _builder.RegisterType<RibbonFactory>()
                .SingleInstance();

            _container = _builder.Build();
            ServiceLocator = new AutofacServiceLocator(_container);

            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => ServiceLocator);
        }

        private static ILog SetupLog()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var fileName = Path.Combine(location, ".config");
            if (File.Exists(fileName))
                XmlConfigurator.Configure(new FileInfo(fileName));
            else
                BasicConfigurator.Configure();

            return LogManager.GetLogger("FacebookToOutlook logger");
        }

        public void Dispose()
        {
            if (System.Windows.Application.Current != null)
                System.Windows.Application.Current.Shutdown();
        }
    }
}
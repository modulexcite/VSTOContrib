﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSTOContrib.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VSTOContrib.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while checking for an update:
        ///{0}.
        /// </summary>
        internal static string Deployment_CheckForUpdateFailed {
            get {
                return ResourceManager.GetString("Deployment_CheckForUpdateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application is not network deployed..
        /// </summary>
        internal static string Deployment_NotNetworkDeployed {
            get {
                return ResourceManager.GetString("Deployment_NotNetworkDeployed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No update available.
        /// </summary>
        internal static string Deployment_NoUpdateAvailable {
            get {
                return ResourceManager.GetString("Deployment_NoUpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} successfully upgraded to v{1}.
        ///
        ///Restart {0} for changes to take affect..
        /// </summary>
        internal static string Deployment_Success {
            get {
                return ResourceManager.GetString("Deployment_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured updating Application:
        ///{0}.
        /// </summary>
        internal static string Deployment_UpdateFailed {
            get {
                return ResourceManager.GetString("Deployment_UpdateFailed", resourceCulture);
            }
        }
    }
}

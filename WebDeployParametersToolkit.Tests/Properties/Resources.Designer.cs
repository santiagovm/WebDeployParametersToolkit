﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDeployParametersToolkit.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebDeployParametersToolkit.Tests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!--
        ///  For more information on how to configure your ASP.NET application, please visit
        ///  http://go.microsoft.com/fwlink/?LinkId=301879
        ///  --&gt;
        ///&lt;configuration&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;add name=&quot;foo&quot; connectionString=&quot;foo-conn-string&quot; /&gt;
        ///    &lt;add name=&quot;bar&quot; connectionString=&quot;bar-conn-string&quot; /&gt;
        ///  &lt;/connectionStrings&gt;
        ///  
        ///  &lt;appSettings&gt;
        ///    &lt;add key=&quot;foo-key&quot; value=&quot;foo-value&quot; /&gt;
        ///    &lt;add key=&quot;bar-key&quot; value=&quot;bar-value&quot; /&gt;
        ///
        ///  &lt;/appSettings&gt;
        ///  
        ///  &lt;!--
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string web_config_with_app_settings {
            get {
                return ResourceManager.GetString("web_config_with_app_settings", resourceCulture);
            }
        }
    }
}
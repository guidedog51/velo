﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeDistributor.Test.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BikeDistributor.Test.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;html&gt;
        ///	&lt;body&gt;
        ///		&lt;h1&gt;Order Receipt for Anywhere Bike Shop&lt;/h1&gt;
        ///			&lt;ul&gt;
        ///				&lt;li&gt;4 x Specialized S-Works Venge Dura-Ace @ (list price 5555.55 * discount 1.0) = 22222.20&lt;/li&gt;
        ///
        ///			&lt;/ul&gt;
        ///		&lt;h3&gt;Sub-Total: 22222.20&lt;/h3&gt;
        ///		&lt;h3&gt;Tax: 2111.11&lt;/h3&gt;
        ///		&lt;h2&gt;Total: 24333.31&lt;/h3&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string DuraAceHtmlReceipt {
            get {
                return ResourceManager.GetString("DuraAceHtmlReceipt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order Receipt for Anywhere Bike Shop
        ///\t4 x Specialized S-Works Venge Dura-Ace @ (list price 5555.55 * discount 1.0) = 22222.20
        ///
        ///Sub-Total: 22222.20
        ///Tax: 2111.11
        ///Total: 24333.31.
        /// </summary>
        internal static string DuraAceTextReceipt {
            get {
                return ResourceManager.GetString("DuraAceTextReceipt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///	&lt;body&gt;
        ///		&lt;h1&gt;Order Receipt for Anywhere Bike Shop&lt;/h1&gt;
        ///			&lt;ul&gt;
        ///				&lt;li&gt;30 x Gazelle Tour Populair @ (list price 1000.00 * discount 0.9) = 27000.00&lt;/li&gt;
        ///
        ///			&lt;/ul&gt;
        ///		&lt;h3&gt;Sub-Total: 27000.00&lt;/h3&gt;
        ///		&lt;h3&gt;Tax: 2565.00&lt;/h3&gt;
        ///		&lt;h2&gt;Total: 29565.00&lt;/h3&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string TourHtmlReceipt {
            get {
                return ResourceManager.GetString("TourHtmlReceipt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order Receipt for Anywhere Bike Shop
        ///\t30 x Gazelle Tour Populair @ (list price 1000.00 * discount 0.9) = 27000.00
        ///
        ///Sub-Total: 27000.00
        ///Tax: 2565.00
        ///Total: 29565.00.
        /// </summary>
        internal static string TourTextReceipt {
            get {
                return ResourceManager.GetString("TourTextReceipt", resourceCulture);
            }
        }
    }
}

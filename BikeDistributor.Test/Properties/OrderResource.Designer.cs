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
    internal class OrderResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OrderResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BikeDistributor.Test.Properties.OrderResource", typeof(OrderResource).Assembly);
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
        ///				&lt;li&gt;1 x Specialized Venge Elite = $2,000.00&lt;/li&gt;
        ///			&lt;/ul&gt;
        ///		&lt;h3&gt;Sub-Total: $2,000.00&lt;/h3&gt;
        ///		&lt;h3&gt;Tax: $145.00&lt;/h3&gt;
        ///		&lt;h2&gt;Total: $2,145.00&lt;/h2&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string vengeEliteHtmlReceipt {
            get {
                return ResourceManager.GetString("vengeEliteHtmlReceipt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order Receipt for Anywhere Bike Shop
        ///	1 x Specialized Venge Elite = $2,000.00
        ///Sub-Total: $2,000.00
        ///Tax: $145.00
        ///Total: $2,145.00.
        /// </summary>
        internal static string vengeEliteTextReceipt {
            get {
                return ResourceManager.GetString("vengeEliteTextReceipt", resourceCulture);
            }
        }
    }
}

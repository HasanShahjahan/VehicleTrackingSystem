﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleTrackingSystem.Api {
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
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VehicleTrackingSystem.Api.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is already exist..
        /// </summary>
        public static string AlreadyExist {
            get {
                return ResourceManager.GetString("AlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verification token is empty..
        /// </summary>
        public static string EmptyToken {
            get {
                return ResourceManager.GetString("EmptyToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username or password is incorrect..
        /// </summary>
        public static string IncorrectUsernameOrPassword {
            get {
                return ResourceManager.GetString("IncorrectUsernameOrPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verification token is invalid..
        /// </summary>
        public static string InvalidToken {
            get {
                return ResourceManager.GetString("InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not found.	.
        /// </summary>
        public static string NotFound {
            get {
                return ResourceManager.GetString("NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not permitted to add position of another vehicle..
        /// </summary>
        public static string NotPermittedToAddPosition {
            get {
                return ResourceManager.GetString("NotPermittedToAddPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not permitted to edit another users vehicle..
        /// </summary>
        public static string NotPermittedToEditVehicle {
            get {
                return ResourceManager.GetString("NotPermittedToEditVehicle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not permitted to invoke this service..
        /// </summary>
        public static string NotPermittedToInvokeService {
            get {
                return ResourceManager.GetString("NotPermittedToInvokeService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required field is missing {0}.
        /// </summary>
        public static string RequiredFieldissing {
            get {
                return ResourceManager.GetString("RequiredFieldissing", resourceCulture);
            }
        }
    }
}

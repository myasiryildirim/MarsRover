﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarsRover.Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarsRover.Resource.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Yön bilgisi boş olamaz..
        /// </summary>
        public static string DirectionInformationCannotBeEmpty {
            get {
                return ResourceManager.GetString("DirectionInformationCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alan boyutunu giriniz: .
        /// </summary>
        public static string EnterTheAreaSize {
            get {
                return ResourceManager.GetString("EnterTheAreaSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yön bilgisini giriniz:.
        /// </summary>
        public static string EnterTheDirectionInformation {
            get {
                return ResourceManager.GetString("EnterTheDirectionInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Başlangıç konumunu giriniz:.
        /// </summary>
        public static string EnterTheRobotLocation {
            get {
                return ResourceManager.GetString("EnterTheRobotLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Girilen konum bilgisi standartlara uygun değil!.
        /// </summary>
        public static string LocationInformationNonStandart {
            get {
                return ResourceManager.GetString("LocationInformationNonStandart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Çıkış yapmak için lütfen bir tuşa basın.
        /// </summary>
        public static string PressLogOutKey {
            get {
                return ResourceManager.GetString("PressLogOutKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hareket Engellendi!! Yapılan işlem genel alan boyutunun dışına çıkmanıza sebep olduğu için engellendi..
        /// </summary>
        public static string SpaceError {
            get {
                return ResourceManager.GetString("SpaceError", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleViewModels.Properties {
    using System.Drawing;

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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SampleViewModels.Properties.Resources", typeof(Resources).Assembly);
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

        internal static string AddDocumentClickListener
        {
            get
            {
                return ResourceManager.GetString("AddDocumentClickListener", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap button
        {
            get
            {
                object obj = ResourceManager.GetObject("button", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap checkbox
        {
            get
            {
                object obj = ResourceManager.GetObject("checkbox", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap color
        {
            get
            {
                object obj = ResourceManager.GetObject("color", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap date
        {
            get
            {
                object obj = ResourceManager.GetObject("date", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap define_setters
        {
            get
            {
                object obj = ResourceManager.GetObject("define_setters", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap div
        {
            get
            {
                object obj = ResourceManager.GetObject("div", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap grid
        {
            get
            {
                object obj = ResourceManager.GetObject("grid", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap image
        {
            get
            {
                object obj = ResourceManager.GetObject("image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap label
        {
            get
            {
                object obj = ResourceManager.GetObject("label", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to function queryInputElements() {
        ///    const returnObjects = [];
        ///    const inputElements = document.getElementsByTagName(&apos;input&apos;);
        ///
        ///    for (const htmlElement of inputElements) {
        ///        const inputData = new Object();
        ///
        ///        inputData.id = htmlElement.id;
        ///        inputData.value = handleValueExtract(htmlElement);
        ///        inputData.name = htmlElement.name;
        ///        inputData.max = htmlElement.max;
        ///        inputData.min = htmlElement.min;
        ///        inputData.isChecked = htmlElement.checked;
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryInputElementsInDOM
        {
            get
            {
                return ResourceManager.GetString("QueryInputElementsInDOM", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap radio
        {
            get
            {
                object obj = ResourceManager.GetObject("radio", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to function setValues(elementId, value) {
        ///    const elem = document.getElementById(elementId);
        ///
        ///    if (elem === null) return;
        ///
        ///    // if it&apos;s text
        ///    if (elem.innerText) {
        ///        elem.innerText = value;
        ///    }
        ///
        ///    // if it&apos;s an input type
        ///    else if (elem.type) {
        ///
        ///        // if checkbox or radio, convert to boolean and apply to checked property
        ///        if (elem.type === &apos;checkbox&apos; || elem.type === &apos;radio&apos; ) {
        ///            elem.checked = (value.toLowerCase() === &apos;true&apos;);
        ///        }
        ///        // [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SetValuesInDom
        {
            get
            {
                return ResourceManager.GetString("SetValuesInDom", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap slider
        {
            get
            {
                object obj = ResourceManager.GetObject("slider", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap text_input
        {
            get
            {
                object obj = ResourceManager.GetObject("text_input", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap time
        {
            get
            {
                object obj = ResourceManager.GetObject("time", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap web_window
        {
            get
            {
                object obj = ResourceManager.GetObject("web_window", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace Noesis
{

    public partial class UIPropertyMetadata
    {
        public UIPropertyMetadata(object defaultValue)
            : this(Create(defaultValue, null), true)
        {
        }

        public UIPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback)
            : this(Create(defaultValue, propertyChangedCallback), true)
        {
        }

        private static IntPtr Create(object defaultValue, PropertyChangedCallback propertyChangedCallback)
        {
            return Create(defaultValue, propertyChangedCallback,
                (def, invoke) => Noesis_CreateUIPropertyMetadata_(def, invoke));
        }

        #region Imports
        private static IntPtr Noesis_CreateUIPropertyMetadata_(HandleRef defaultValue,
            DelegateInvokePropertyChangedCallback invokePropertyChangedCallback)
        {
            IntPtr result = Noesis_CreateUIPropertyMetadata(defaultValue,
                invokePropertyChangedCallback);
            Error.Check();
            return result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_CreateUIPropertyMetadata(HandleRef defaultValue,
            DelegateInvokePropertyChangedCallback invokePropertyChangedCallback);

        #endregion
    }

}

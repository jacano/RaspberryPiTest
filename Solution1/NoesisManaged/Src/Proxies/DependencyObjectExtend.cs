using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Noesis
{

    public partial class DependencyObject
    {
        public object GetValue(DependencyProperty dp)
        {
            if (dp == null)
            {
                throw new Exception("Can't get value, DependencyProperty is null");
            }

            Type dpType = dp.PropertyType;

            GetDelegate getDelegate;
            if (dpType.GetTypeInfo().IsEnum)
            {
                _getFunctions.TryGetValue(typeof(int).TypeHandle, out getDelegate);
                int value = (int)getDelegate(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle);
                return Enum.ToObject(dpType, value);
            }
            else if (_getFunctions.TryGetValue(dpType.TypeHandle, out getDelegate))
            {
                return getDelegate(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle);
            }
            else
            {
                IntPtr ptr = Noesis_DependencyGet_BaseComponent_(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle);
                return Noesis.Extend.GetProxy(ptr, false);
            }
        }


        public void SetValue(DependencyProperty dp, object value)
        {
            if (dp == null)
            {
                throw new Exception("Can't set value, DependencyProperty is null");
            }

            Type dpType = dp.PropertyType;

            SetDelegate setDelegate;
            if (dpType.GetTypeInfo().IsEnum)
            {
                _setFunctions.TryGetValue(typeof(int).TypeHandle, out setDelegate);
                setDelegate(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle, (int)Convert.ToInt64(value));
            }
            else if (_setFunctions.TryGetValue(dpType.TypeHandle, out setDelegate))
            {
                setDelegate(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle, value);
            }
            else
            {
                Noesis_DependencySet_BaseComponent_(swigCPtr.Handle, DependencyProperty.getCPtr(dp).Handle,
                    Noesis.Extend.GetInstanceHandle(value).Handle);
            }
        }

        #region Getter and Setter map

        private delegate object GetDelegate(IntPtr cPtr, IntPtr dp);
        private static Dictionary<RuntimeTypeHandle, GetDelegate> _getFunctions = CreateGetFunctions();

        private delegate void SetDelegate(IntPtr cPtr, IntPtr dp, object value);
        private static Dictionary<RuntimeTypeHandle, SetDelegate> _setFunctions = CreateSetFunctions();

        private static Dictionary<RuntimeTypeHandle, GetDelegate> CreateGetFunctions()
        {
            Dictionary<RuntimeTypeHandle, GetDelegate> getFunctions =
                new Dictionary<RuntimeTypeHandle, GetDelegate>(46);

            getFunctions[typeof(bool).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_Bool_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(float).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_Float_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(double).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_Double_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(decimal).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (decimal)Noesis_DependencyGet_Double_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(int).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_Int_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(long).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (long)Noesis_DependencyGet_Int_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(uint).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_UInt_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(ulong).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (ulong)Noesis_DependencyGet_UInt_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(char).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (char)Noesis_DependencyGet_UInt_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(short).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_Short_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(sbyte).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (sbyte)Noesis_DependencyGet_Short_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(ushort).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return Noesis_DependencyGet_UShort_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(byte).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                return (byte)Noesis_DependencyGet_UShort_(cPtr, dp, false, out isNull);
            };
            getFunctions[typeof(string).TypeHandle] = (cPtr, dp) =>
            {
                IntPtr ptr = Noesis_DependencyGet_String_(cPtr, dp);
                return Noesis.Extend.StringFromNativeUtf8(ptr);
            };
            getFunctions[typeof(Noesis.Color).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Color_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Color>(ptr);
            };
            getFunctions[typeof(Noesis.Point).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Point_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Point>(ptr);
            };
            getFunctions[typeof(Noesis.Rect).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Rect_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Rect>(ptr);
            };
            getFunctions[typeof(Noesis.Size).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Size_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Size>(ptr);
            };
            getFunctions[typeof(Noesis.Thickness).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Thickness_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Thickness>(ptr);
            };
            getFunctions[typeof(Noesis.CornerRadius).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_CornerRadius_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.CornerRadius>(ptr);
            };
            getFunctions[typeof(TimeSpan).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_TimeSpan_(cPtr, dp, false, out isNull);
                return (TimeSpan)Marshal.PtrToStructure<Noesis.TimeSpanStruct>(ptr);
            };
            getFunctions[typeof(Noesis.Duration).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Duration_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.Duration>(ptr);
            };
            getFunctions[typeof(Noesis.KeyTime).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_KeyTime_(cPtr, dp, false, out isNull);
                return Marshal.PtrToStructure<Noesis.KeyTime>(ptr);
            };

            getFunctions[typeof(bool?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                bool val = Noesis_DependencyGet_Bool_(cPtr, dp, true, out isNull);
                return isNull ? null : (bool?)val;
            };
            getFunctions[typeof(float?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                float val = Noesis_DependencyGet_Float_(cPtr, dp, true, out isNull);
                return isNull ? null : (float?)val;
            };
            getFunctions[typeof(double?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                double val = Noesis_DependencyGet_Double_(cPtr, dp, true, out isNull);
                return isNull ? null : (double?)val;
            };
            getFunctions[typeof(decimal?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                double val = Noesis_DependencyGet_Double_(cPtr, dp, true, out isNull);
                return isNull ? null : (decimal?)(decimal)val;
            };
            getFunctions[typeof(int?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                int val = Noesis_DependencyGet_Int_(cPtr, dp, true, out isNull);
                return isNull ? null : (int?)val;
            };
            getFunctions[typeof(long?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                int val = Noesis_DependencyGet_Int_(cPtr, dp, true, out isNull);
                return isNull ? null : (long?)(long)val;
            };
            getFunctions[typeof(uint?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                uint val = Noesis_DependencyGet_UInt_(cPtr, dp, true, out isNull);
                return isNull ? null : (uint?)val;
            };
            getFunctions[typeof(ulong?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                uint val = Noesis_DependencyGet_UInt_(cPtr, dp, true, out isNull);
                return isNull ? null : (ulong?)(ulong)val;
            };
            getFunctions[typeof(char?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                uint val = Noesis_DependencyGet_UInt_(cPtr, dp, true, out isNull);
                return isNull ? null : (char?)(char)val;
            };
            getFunctions[typeof(short?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                short val = Noesis_DependencyGet_Short_(cPtr, dp, true, out isNull);
                return isNull ? null : (short?)val;
            };
            getFunctions[typeof(sbyte?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                short val = Noesis_DependencyGet_Short_(cPtr, dp, true, out isNull);
                return isNull ? null : (sbyte?)(sbyte)val;
            };
            getFunctions[typeof(ushort?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                ushort val = Noesis_DependencyGet_UShort_(cPtr, dp, true, out isNull);
                return isNull ? null : (ushort?)val;
            };
            getFunctions[typeof(byte?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                ushort val = Noesis_DependencyGet_UShort_(cPtr, dp, true, out isNull);
                return isNull ? null : (byte?)(byte)val;
            };
            getFunctions[typeof(Noesis.Color?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Color_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Color?)Marshal.PtrToStructure<Noesis.Color>(ptr);
            };
            getFunctions[typeof(Noesis.Point?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Point_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Point?)Marshal.PtrToStructure<Noesis.Point>(ptr);
            };
            getFunctions[typeof(Noesis.Rect?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Rect_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Rect?)Marshal.PtrToStructure<Noesis.Rect>(ptr);
            };
            getFunctions[typeof(Noesis.Size?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Size_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Size?)Marshal.PtrToStructure<Noesis.Size>(ptr);
            };
            getFunctions[typeof(Noesis.Thickness?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Thickness_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Thickness?)Marshal.PtrToStructure<Noesis.Thickness>(ptr);
            };
            getFunctions[typeof(Noesis.CornerRadius?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_CornerRadius_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.CornerRadius?)Marshal.PtrToStructure<Noesis.CornerRadius>(ptr);
            };
            getFunctions[typeof(TimeSpan?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_TimeSpan_(cPtr, dp, true, out isNull);
                return isNull ? null : (TimeSpan?)(TimeSpan)Marshal.PtrToStructure<Noesis.TimeSpanStruct>(ptr);
            };
            getFunctions[typeof(Noesis.Duration?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_Duration_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.Duration?)Marshal.PtrToStructure<Noesis.Duration>(ptr);
            };
            getFunctions[typeof(Noesis.KeyTime?).TypeHandle] = (cPtr, dp) =>
            {
                bool isNull;
                IntPtr ptr = Noesis_DependencyGet_KeyTime_(cPtr, dp, true, out isNull);
                return isNull ? null : (Noesis.KeyTime?)Marshal.PtrToStructure<Noesis.KeyTime>(ptr);
            };
            getFunctions[typeof(Type).TypeHandle] = (cPtr, dp) =>
            {
                IntPtr ptr = Noesis_DependencyGet_BaseComponent_(cPtr, dp);
                if (ptr != IntPtr.Zero)
                {
                    ResourceKeyType key = new ResourceKeyType(ptr, false);
                    return key.Type;
                }
                else
                {
                    return null;
                }
            };

            return getFunctions;
        }

        private static Dictionary<RuntimeTypeHandle, SetDelegate> CreateSetFunctions()
        {
            Dictionary<RuntimeTypeHandle, SetDelegate> setFunctions =
                new Dictionary<RuntimeTypeHandle, SetDelegate>(46);

            setFunctions[typeof(bool).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Bool_(cPtr, dp, (bool)value, false, false);
            };
            setFunctions[typeof(float).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Float_(cPtr, dp, (float)value, false, false);
            };
            setFunctions[typeof(double).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Double_(cPtr, dp, (double)value, false, false);
            };
            setFunctions[typeof(decimal).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Double_(cPtr, dp, (double)(decimal)value, false, false);
            };
            setFunctions[typeof(int).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Int_(cPtr, dp, (int)value, false, false);
            };
            setFunctions[typeof(long).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Int_(cPtr, dp, (int)(long)value, false, false);
            };
            setFunctions[typeof(uint).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_UInt_(cPtr, dp, (uint)value, false, false);
            };
            setFunctions[typeof(ulong).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_UInt_(cPtr, dp, (uint)(ulong)value, false, false);
            };
            setFunctions[typeof(char).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_UInt_(cPtr, dp, (uint)(char)value, false, false);
            };
            setFunctions[typeof(short).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Short_(cPtr, dp, (short)value, false, false);
            };
            setFunctions[typeof(sbyte).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Short_(cPtr, dp, (short)(sbyte)value, false, false);
            };
            setFunctions[typeof(ushort).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_UShort_(cPtr, dp, (ushort)value, false, false);
            };
            setFunctions[typeof(byte).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_UShort_(cPtr, dp, (ushort)(byte)value, false, false);
            };
            setFunctions[typeof(string).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_String_(cPtr, dp, value == null ? string.Empty : value.ToString());
            };
            setFunctions[typeof(Noesis.Color).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Color_(cPtr, dp, (Noesis.Color)value, false, false);
            };
            setFunctions[typeof(Noesis.Point).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Point_(cPtr, dp, (Noesis.Point)value, false, false);
            };
            setFunctions[typeof(Noesis.Rect).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Rect_(cPtr, dp, (Noesis.Rect)value, false, false);
            };
            setFunctions[typeof(Noesis.Size).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Size_(cPtr, dp, (Noesis.Size)value, false, false);
            };
            setFunctions[typeof(Noesis.Thickness).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Thickness_(cPtr, dp, (Noesis.Thickness)value, false, false);
            };
            setFunctions[typeof(Noesis.CornerRadius).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_CornerRadius_(cPtr, dp, (Noesis.CornerRadius)value, false, false);
            };
            setFunctions[typeof(TimeSpan).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_TimeSpan_(cPtr, dp, (Noesis.TimeSpanStruct)((TimeSpan)value), false, false);
            };
            setFunctions[typeof(Noesis.Duration).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_Duration_(cPtr, dp, (Noesis.Duration)value, false, false);
            };
            setFunctions[typeof(Noesis.KeyTime).TypeHandle] = (cPtr, dp, value) =>
            {
                Noesis_DependencySet_KeyTime_(cPtr, dp, (Noesis.KeyTime)value, false, false);
            };
            setFunctions[typeof(bool?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Bool_(cPtr, dp, default(bool), true, true);
                }
                else
                {
                    Noesis_DependencySet_Bool_(cPtr, dp, (bool)value, true, false);
                }
            };
            setFunctions[typeof(float?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Float_(cPtr, dp, default(float), true, true);
                }
                else
                {
                    Noesis_DependencySet_Float_(cPtr, dp, (float)value, true, false);
                }
            };
            setFunctions[typeof(double?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Double_(cPtr, dp, default(double), true, true);
                }
                else
                {
                    Noesis_DependencySet_Double_(cPtr, dp, (double)value, true, false);
                }
            };
            setFunctions[typeof(decimal?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Double_(cPtr, dp, default(double), true, true);
                }
                else
                {
                    Noesis_DependencySet_Double_(cPtr, dp, (double)(decimal)value, true, false);
                }
            };
            setFunctions[typeof(int?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Int_(cPtr, dp, default(int), true, true);
                }
                else
                {
                    Noesis_DependencySet_Int_(cPtr, dp, (int)value, true, false);
                }
            };
            setFunctions[typeof(long?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Int_(cPtr, dp, default(int), true, true);
                }
                else
                {
                    Noesis_DependencySet_Int_(cPtr, dp, (int)(long)value, true, false);
                }
            };
            setFunctions[typeof(uint?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, default(uint), true, true);
                }
                else
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, (uint)value, true, false);
                }
            };
            setFunctions[typeof(ulong?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, default(uint), true, true);
                }
                else
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, (uint)(ulong)value, true, false);
                }
            };
            setFunctions[typeof(char?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, default(uint), true, true);
                }
                else
                {
                    Noesis_DependencySet_UInt_(cPtr, dp, (uint)(char)value, true, false);
                }
            };
            setFunctions[typeof(short?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Short_(cPtr, dp, default(short), true, true);
                }
                else
                {
                    Noesis_DependencySet_Short_(cPtr, dp, (short)value, true, false);
                }
            };
            setFunctions[typeof(sbyte?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Short_(cPtr, dp, default(short), true, true);
                }
                else
                {
                    Noesis_DependencySet_Short_(cPtr, dp, (short)(sbyte)value, true, false);
                }
            };
            setFunctions[typeof(ushort?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_UShort_(cPtr, dp, default(ushort), true, true);
                }
                else
                {
                    Noesis_DependencySet_UShort_(cPtr, dp, (ushort)value, true, false);
                }
            };
            setFunctions[typeof(byte?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_UShort_(cPtr, dp, default(ushort), true, true);
                }
                else
                {
                    Noesis_DependencySet_UShort_(cPtr, dp, (ushort)(byte)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.Color?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Color_(cPtr, dp, default(Noesis.Color), true, true);
                }
                else
                {
                    Noesis_DependencySet_Color_(cPtr, dp, (Noesis.Color)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.Point?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Point_(cPtr, dp, default(Noesis.Point), true, true);
                }
                else
                {
                    Noesis_DependencySet_Point_(cPtr, dp, (Noesis.Point)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.Rect?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Rect_(cPtr, dp, default(Noesis.Rect), true, true);
                }
                else
                {
                    Noesis_DependencySet_Rect_(cPtr, dp, (Noesis.Rect)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.Size?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Size_(cPtr, dp, default(Noesis.Size), true, true);
                }
                else
                {
                    Noesis_DependencySet_Size_(cPtr, dp, (Noesis.Size)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.Thickness?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Thickness_(cPtr, dp, default(Noesis.Thickness), true, true);
                }
                else
                {
                    Noesis_DependencySet_Thickness_(cPtr, dp, (Noesis.Thickness)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.CornerRadius?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_CornerRadius_(cPtr, dp, default(Noesis.CornerRadius), true, true);
                }
                else
                {
                    Noesis_DependencySet_CornerRadius_(cPtr, dp, (Noesis.CornerRadius)value, true, false);
                }
            };
            setFunctions[typeof(TimeSpan?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_TimeSpan_(cPtr, dp, default(Noesis.TimeSpanStruct), true, true);
                }
                else
                {
                    Noesis_DependencySet_TimeSpan_(cPtr, dp, (Noesis.TimeSpanStruct)((TimeSpan)value), true, false);
                }
            };
            setFunctions[typeof(Noesis.Duration?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_Duration_(cPtr, dp, default(Noesis.Duration), true, true);
                }
                else
                {
                    Noesis_DependencySet_Duration_(cPtr, dp, (Noesis.Duration)value, true, false);
                }
            };
            setFunctions[typeof(Noesis.KeyTime?).TypeHandle] = (cPtr, dp, value) =>
            {
                if (value == null)
                {
                    Noesis_DependencySet_KeyTime_(cPtr, dp, default(Noesis.KeyTime), true, true);
                }
                else
                {
                    Noesis_DependencySet_KeyTime_(cPtr, dp, (Noesis.KeyTime)value, true, false);
                }
            };
            setFunctions[typeof(Type).TypeHandle] = (cPtr, dp, value) =>
            {
                ResourceKeyType key = Noesis.Extend.GetResourceKeyType((Type)value);
                Noesis_DependencySet_BaseComponent_(cPtr, dp, Noesis.Extend.GetInstanceHandle(key).Handle);
            };

            return setFunctions;
        }

        #endregion

        #region Imports

        private static void CheckProperty(IntPtr dependencyObject, IntPtr dependencyProperty,
            string msg)
        {
            if (dependencyObject == IntPtr.Zero)
            {
                throw new Exception("Can't " + msg + " value, DependencyObject is null");
            }

            if (dependencyProperty == IntPtr.Zero)
            {
                throw new Exception("Can't " + msg + " value, DependencyProperty is null");
            }
        }

        private static bool Noesis_DependencyGet_Bool_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            bool result = Noesis_DependencyGet_Bool(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static float Noesis_DependencyGet_Float_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            float result = Noesis_DependencyGet_Float(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static double Noesis_DependencyGet_Double_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            double result = Noesis_DependencyGet_Double(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static int Noesis_DependencyGet_Int_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            int result = Noesis_DependencyGet_Int(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static uint Noesis_DependencyGet_UInt_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            uint result = Noesis_DependencyGet_UInt(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static short Noesis_DependencyGet_Short_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            short result = Noesis_DependencyGet_Short(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static ushort Noesis_DependencyGet_UShort_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            ushort result = Noesis_DependencyGet_UShort(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_String_(IntPtr dependencyObject, IntPtr dependencyProperty)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_String(dependencyObject, dependencyProperty);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Color_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Color(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Point_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Point(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Rect_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Rect(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Size_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Size(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Thickness_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Thickness(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_CornerRadius_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_CornerRadius(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_TimeSpan_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_TimeSpan(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_Duration_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_Duration(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_KeyTime_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_KeyTime(dependencyObject, dependencyProperty, isNullable, out isNull);
            Error.Check();
            return result;
        }

        private static IntPtr Noesis_DependencyGet_BaseComponent_(IntPtr dependencyObject, IntPtr dependencyProperty)
        {
            CheckProperty(dependencyObject, dependencyProperty, "get");
            IntPtr result = Noesis_DependencyGet_BaseComponent(dependencyObject, dependencyProperty);
            Error.Check();
            return result;
        }

        private static void Noesis_DependencySet_Bool_(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Bool(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Float_(IntPtr dependencyObject, IntPtr dependencyProperty,
            float val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Float(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Double_(IntPtr dependencyObject, IntPtr dependencyProperty,
            double val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Double(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Int_(IntPtr dependencyObject, IntPtr dependencyProperty,
            int val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Int(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_UInt_(IntPtr dependencyObject, IntPtr dependencyProperty,
            uint val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_UInt(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Short_(IntPtr dependencyObject, IntPtr dependencyProperty,
            short val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Short(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_UShort_(IntPtr dependencyObject, IntPtr dependencyProperty,
            ushort val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_UShort(dependencyObject, dependencyProperty, val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_String_(IntPtr dependencyObject, IntPtr dependencyProperty,
            string val)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_String(dependencyObject, dependencyProperty, val);
            Error.Check();
        }

        private static void Noesis_DependencySet_Color_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Color val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Color(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Point_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Point val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Point(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Rect_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Rect val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Rect(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Size_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Size val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Size(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Thickness_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Thickness val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Thickness(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_CornerRadius_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.CornerRadius val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_CornerRadius(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_TimeSpan_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.TimeSpanStruct val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_TimeSpan(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_Duration_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.Duration val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_Duration(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_KeyTime_(IntPtr dependencyObject, IntPtr dependencyProperty,
            Noesis.KeyTime val, bool isNullable, bool isNull)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_KeyTime(dependencyObject, dependencyProperty, ref val, isNullable, isNull);
            Error.Check();
        }

        private static void Noesis_DependencySet_BaseComponent_(IntPtr dependencyObject, IntPtr dependencyProperty,
            IntPtr val)
        {
            CheckProperty(dependencyObject, dependencyProperty, "set");
            Noesis_DependencySet_BaseComponent(dependencyObject, dependencyProperty, val);
            Error.Check();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool Noesis_DependencyGet_Bool(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern float Noesis_DependencyGet_Float(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern double Noesis_DependencyGet_Double(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern int Noesis_DependencyGet_Int(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern uint Noesis_DependencyGet_UInt(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern short Noesis_DependencyGet_Short(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern ushort Noesis_DependencyGet_UShort(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_String(IntPtr dependencyObject, IntPtr dependencyProperty);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Color(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Point(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Rect(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Size(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Thickness(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_CornerRadius(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_TimeSpan(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_Duration(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_KeyTime(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool isNullable, [MarshalAs(UnmanagedType.U1)]out bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_DependencyGet_BaseComponent(IntPtr dependencyObject, IntPtr dependencyProperty);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Bool(IntPtr dependencyObject, IntPtr dependencyProperty,
            bool val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Float(IntPtr dependencyObject, IntPtr dependencyProperty,
            float val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Double(IntPtr dependencyObject, IntPtr dependencyProperty,
            double val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Int(IntPtr dependencyObject, IntPtr dependencyProperty,
            int val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_UInt(IntPtr dependencyObject, IntPtr dependencyProperty,
            uint val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Short(IntPtr dependencyObject, IntPtr dependencyProperty,
            short val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_UShort(IntPtr dependencyObject, IntPtr dependencyProperty,
            ushort val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_String(IntPtr dependencyObject, IntPtr dependencyProperty,
            [MarshalAs(UnmanagedType.LPWStr)]string val);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Color(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Color val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Point(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Point val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Rect(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Rect val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Size(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Size val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Thickness(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Thickness val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_CornerRadius(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.CornerRadius val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_TimeSpan(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.TimeSpanStruct val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_Duration(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.Duration val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_KeyTime(IntPtr dependencyObject, IntPtr dependencyProperty,
            ref Noesis.KeyTime val, bool isNullable, bool isNull);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport(Library.Name)]
        private static extern void Noesis_DependencySet_BaseComponent(IntPtr dependencyObject, IntPtr dependencyProperty,
            IntPtr val);

        #endregion
    }

}

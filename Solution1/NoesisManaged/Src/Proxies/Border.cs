//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class Border : Decorator {
  internal new static Border CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Border(cPtr, cMemoryOwn);
  }

  internal Border(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Border obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Border(bool logicalChild) : this(NoesisGUI_PINVOKE.new_Border__SWIG_0(logicalChild), true) {
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public Border() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(Border).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Border__SWIG_1();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty BackgroundProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_BackgroundProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BorderBrushProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_BorderBrushProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BorderThicknessProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_BorderThicknessProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CornerRadiusProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_CornerRadiusProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PaddingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_PaddingProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush Background {
    set {
      NoesisGUI_PINVOKE.Border_Background_set(swigCPtr, Brush.getCPtr(value));
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_Background_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush BorderBrush {
    set {
      NoesisGUI_PINVOKE.Border_BorderBrush_set(swigCPtr, Brush.getCPtr(value));
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Border_BorderBrush_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Thickness BorderThickness {
    set {
      NoesisGUI_PINVOKE.Border_BorderThickness_set(swigCPtr, ref value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Border_BorderThickness_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Thickness>(ret);
      }
      else {
        return new Thickness();
      }
    }

  }

  public CornerRadius CornerRadius {
    set {
      NoesisGUI_PINVOKE.Border_CornerRadius_set(swigCPtr, ref value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Border_CornerRadius_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<CornerRadius>(ret);
      }
      else {
        return new CornerRadius();
      }
    }

  }

  public Thickness Padding {
    set {
      NoesisGUI_PINVOKE.Border_Padding_set(swigCPtr, ref value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Border_Padding_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Thickness>(ret);
      }
      else {
        return new Thickness();
      }
    }

  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Border_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  internal new static IntPtr Extend(string typeName) {
    IntPtr nativeType = NoesisGUI_PINVOKE.Extend_Border(Marshal.StringToHGlobalAnsi(typeName));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return nativeType;
  }
}

}

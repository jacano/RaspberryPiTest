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

public static class LogicalTreeHelper {
  public static FrameworkElement GetParent(FrameworkElement element) {
    IntPtr cPtr = NoesisGUI_PINVOKE.LogicalTreeHelper_GetParent(FrameworkElement.getCPtr(element));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
  }

  public static uint GetChildrenCount(FrameworkElement element) {
    uint ret = NoesisGUI_PINVOKE.LogicalTreeHelper_GetChildrenCount(FrameworkElement.getCPtr(element));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static object GetChild(FrameworkElement element, uint index) {
    IntPtr cPtr = NoesisGUI_PINVOKE.LogicalTreeHelper_GetChild(FrameworkElement.getCPtr(element), index);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public static FrameworkElement FindLogicalNode(FrameworkElement element, string name) {
    IntPtr cPtr = NoesisGUI_PINVOKE.LogicalTreeHelper_FindLogicalNode(FrameworkElement.getCPtr(element), name != null ? name : string.Empty);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

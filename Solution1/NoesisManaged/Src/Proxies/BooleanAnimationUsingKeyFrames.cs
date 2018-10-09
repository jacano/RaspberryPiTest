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

public class BooleanAnimationUsingKeyFrames : AnimationTimeline {
  internal new static BooleanAnimationUsingKeyFrames CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BooleanAnimationUsingKeyFrames(cPtr, cMemoryOwn);
  }

  internal BooleanAnimationUsingKeyFrames(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BooleanAnimationUsingKeyFrames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public BooleanAnimationUsingKeyFrames() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_BooleanAnimationUsingKeyFrames();
  }

  public BooleanKeyFrameCollection KeyFrames {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BooleanAnimationUsingKeyFrames_KeyFrames_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (BooleanKeyFrameCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.BooleanAnimationUsingKeyFrames_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}


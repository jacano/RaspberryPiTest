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
using System.Collections.Generic;
using System.Windows.Input;

namespace Noesis
{

public class CommandBinding : BaseComponent {
  internal new static CommandBinding CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new CommandBinding(cPtr, cMemoryOwn);
  }

  internal CommandBinding(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(CommandBinding obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events

  #region PreviewCanExecute
  public delegate void PreviewCanExecuteHandler(object sender, CanExecuteRoutedEventArgs e);
  public event PreviewCanExecuteHandler PreviewCanExecute {
    add {
      if (!_PreviewCanExecute.ContainsKey(swigCPtr.Handle)) {
        _PreviewCanExecute.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_PreviewCanExecute(_raisePreviewCanExecute, swigCPtr.Handle);
        if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      }

      _PreviewCanExecute[swigCPtr.Handle] += value;
    }
    remove {
      if (_PreviewCanExecute.ContainsKey(swigCPtr.Handle)) {

        _PreviewCanExecute[swigCPtr.Handle] -= value;

        if (_PreviewCanExecute[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_PreviewCanExecute(_raisePreviewCanExecute, swigCPtr.Handle);
          if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();

          _PreviewCanExecute.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaisePreviewCanExecuteCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaisePreviewCanExecuteCallback _raisePreviewCanExecute = RaisePreviewCanExecute;

  [MonoPInvokeCallback(typeof(RaisePreviewCanExecuteCallback))]
  private static void RaisePreviewCanExecute(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (!_PreviewCanExecute.ContainsKey(cPtr)) {
        throw new InvalidOperationException("Delegate not registered for PreviewCanExecute event");
      }
      if (sender == IntPtr.Zero && e == IntPtr.Zero) {
        _PreviewCanExecute.Remove(cPtr);
        return;
      }
      if (Noesis.Extend.Initialized) {
        PreviewCanExecuteHandler handler = _PreviewCanExecute[cPtr];
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new CanExecuteRoutedEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.SetNativePendingError(exception);
    }
  }

  static Dictionary<IntPtr, PreviewCanExecuteHandler> _PreviewCanExecute =
      new Dictionary<IntPtr, PreviewCanExecuteHandler>();
  #endregion

  #region CanExecute
  public delegate void CanExecuteHandler(object sender, CanExecuteRoutedEventArgs e);
  public event CanExecuteHandler CanExecute {
    add {
      if (!_CanExecute.ContainsKey(swigCPtr.Handle)) {
        _CanExecute.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_CanExecute(_raiseCanExecute, swigCPtr.Handle);
        if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      }

      _CanExecute[swigCPtr.Handle] += value;
    }
    remove {
      if (_CanExecute.ContainsKey(swigCPtr.Handle)) {

        _CanExecute[swigCPtr.Handle] -= value;

        if (_CanExecute[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_CanExecute(_raiseCanExecute, swigCPtr.Handle);
          if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();

          _CanExecute.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseCanExecuteCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseCanExecuteCallback _raiseCanExecute = RaiseCanExecute;

  [MonoPInvokeCallback(typeof(RaiseCanExecuteCallback))]
  private static void RaiseCanExecute(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (!_CanExecute.ContainsKey(cPtr)) {
        throw new InvalidOperationException("Delegate not registered for CanExecute event");
      }
      if (sender == IntPtr.Zero && e == IntPtr.Zero) {
        _CanExecute.Remove(cPtr);
        return;
      }
      if (Noesis.Extend.Initialized) {
        CanExecuteHandler handler = _CanExecute[cPtr];
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new CanExecuteRoutedEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.SetNativePendingError(exception);
    }
  }

  static Dictionary<IntPtr, CanExecuteHandler> _CanExecute =
      new Dictionary<IntPtr, CanExecuteHandler>();
  #endregion

  #region PreviewExecuted
  public delegate void PreviewExecutedHandler(object sender, ExecutedRoutedEventArgs e);
  public event PreviewExecutedHandler PreviewExecuted {
    add {
      if (!_PreviewExecuted.ContainsKey(swigCPtr.Handle)) {
        _PreviewExecuted.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_PreviewExecuted(_raisePreviewExecuted, swigCPtr.Handle);
        if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      }

      _PreviewExecuted[swigCPtr.Handle] += value;
    }
    remove {
      if (_PreviewExecuted.ContainsKey(swigCPtr.Handle)) {

        _PreviewExecuted[swigCPtr.Handle] -= value;

        if (_PreviewExecuted[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_PreviewExecuted(_raisePreviewExecuted, swigCPtr.Handle);
          if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();

          _PreviewExecuted.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaisePreviewExecutedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaisePreviewExecutedCallback _raisePreviewExecuted = RaisePreviewExecuted;

  [MonoPInvokeCallback(typeof(RaisePreviewExecutedCallback))]
  private static void RaisePreviewExecuted(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (!_PreviewExecuted.ContainsKey(cPtr)) {
        throw new InvalidOperationException("Delegate not registered for PreviewExecuted event");
      }
      if (sender == IntPtr.Zero && e == IntPtr.Zero) {
        _PreviewExecuted.Remove(cPtr);
        return;
      }
      if (Noesis.Extend.Initialized) {
        PreviewExecutedHandler handler = _PreviewExecuted[cPtr];
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new ExecutedRoutedEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.SetNativePendingError(exception);
    }
  }

  static Dictionary<IntPtr, PreviewExecutedHandler> _PreviewExecuted =
      new Dictionary<IntPtr, PreviewExecutedHandler>();
  #endregion

  #region Executed
  public delegate void ExecutedHandler(object sender, ExecutedRoutedEventArgs e);
  public event ExecutedHandler Executed {
    add {
      if (!_Executed.ContainsKey(swigCPtr.Handle)) {
        _Executed.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_Executed(_raiseExecuted, swigCPtr.Handle);
        if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      }

      _Executed[swigCPtr.Handle] += value;
    }
    remove {
      if (_Executed.ContainsKey(swigCPtr.Handle)) {

        _Executed[swigCPtr.Handle] -= value;

        if (_Executed[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_Executed(_raiseExecuted, swigCPtr.Handle);
          if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();

          _Executed.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseExecutedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseExecutedCallback _raiseExecuted = RaiseExecuted;

  [MonoPInvokeCallback(typeof(RaiseExecutedCallback))]
  private static void RaiseExecuted(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (!_Executed.ContainsKey(cPtr)) {
        throw new InvalidOperationException("Delegate not registered for Executed event");
      }
      if (sender == IntPtr.Zero && e == IntPtr.Zero) {
        _Executed.Remove(cPtr);
        return;
      }
      if (Noesis.Extend.Initialized) {
        ExecutedHandler handler = _Executed[cPtr];
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new ExecutedRoutedEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.SetNativePendingError(exception);
    }
  }

  static Dictionary<IntPtr, ExecutedHandler> _Executed =
      new Dictionary<IntPtr, ExecutedHandler>();
  #endregion

  #endregion

  public ICommand Command {
    get {
      return GetCommandHelper() as ICommand;
    }
    set {
      SetCommandHelper(value);
    }
  }

  public CommandBinding() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_CommandBinding__SWIG_0();
  }

  private object GetCommandHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.CommandBinding_GetCommandHelper(swigCPtr);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private void SetCommandHelper(object command) {
    NoesisGUI_PINVOKE.CommandBinding_SetCommandHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(command));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.CommandBinding_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}


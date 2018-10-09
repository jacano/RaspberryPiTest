using System;
using Khronos;
using NoesisApp;
using OpenGL;

public class RaspDisplay : Display
{
    private readonly IntPtr handler;

    public RaspDisplay()
    {
        try
        {
            string envDebug = Environment.GetEnvironmentVariable("DEBUG");
            if (envDebug == "GL")
            {
                Khronos.KhronosApi.Log += delegate (object sender, KhronosLogEventArgs e)
                {
                    Console.WriteLine(e.ToString());
                };
                Khronos.KhronosApi.LogEnabled = true;
            }

            // RPi runs on EGL
            Egl.IsRequired = true;

            if (Egl.IsAvailable == false)
                throw new InvalidOperationException("EGL is not available. Aborting.");

            //TODO
            var nativeWindow = new VideoCoreWindow();

            handler = nativeWindow.Handle;

            //var eglContext = DeviceContext.Create(nativeWindow.Display, nativeWindow.Handle);

            //eglContext.ChoosePixelFormat(new DevicePixelFormat(32));

            //IntPtr glContext = eglContext.CreateContext(IntPtr.Zero);

            //eglContext.MakeCurrent(glContext);


            //eglContext.DeleteContext(glContext);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }


    public override IntPtr NativeHandle => handler;

    public override int ClientWidth => 1024;

    public override int ClientHeight => 768;

    public override void EnterMessageLoop()
    {
        while (ProcessMessages())
        {
            Render?.Invoke(this);
        }
    }

    private bool ProcessMessages()
    {
        return true;
    }
}
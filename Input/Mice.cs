using Avalonia.Input;
using Avalonia.Input.Raw;
using System;
using System.Linq;

namespace Avalonia.LinuxFramebuffer
{
    public unsafe class Mice
    {
        private readonly double _width;
        private readonly double _height;
        private double _x;
        private double _y;

        public event Action<RawInputEventArgs> Event;

        public Mice(double width, double height)
        {
            _width = width;
            _height = height;
        }

        private void Worker()
        {

            var mouseDevices = EvDevDevice.MouseDevices.Where(d => d.IsMouse).ToList();
            if (mouseDevices.Count == 0)
                return;
            while (true)
            {
                try
                {
                    foreach (var dev in mouseDevices)
                    {
                        while(true)
                        {
                            var ev = dev.NextEvent();
                            if (!ev.HasValue)
                                break;

                            //LinuxFramebufferPlatform.Threading.Send(() => ProcessEvent(dev, ev.Value));
                        } 
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.ToString());
                }
            }
        }
    }
}

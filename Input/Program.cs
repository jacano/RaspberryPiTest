using Avalonia.LinuxFramebuffer;
using System;
using System.Linq;

namespace Input
{
    class Program
    {
        private static double _width;
        private static double _height;
        private static double _x;
        private static double _y;

        static void Main()
        {
            var mouseDevices = EvDevDevice.MouseDevices.ToList();
            if (mouseDevices.Count == 0)
                return;

            foreach (var mice in mouseDevices)
            {
                Console.WriteLine($"mouse: {mice.Name}");
            }
            _width = 1024;
            _height = 768;

            while (true)
            {
                try
                {
                    foreach (var dev in mouseDevices)
                    {
                        while (true)
                        {
                            var ev = dev.NextEvent();
                            if (!ev.HasValue)
                                break;

                            ProcessEvent(dev, ev.Value);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.ToString());
                }
            }
        }

        static double TranslateAxis(input_absinfo axis, int value, double max)
        {
            return (value - axis.minimum) / (double)(axis.maximum - axis.minimum) * max;
        }

        private static void ProcessEvent(EvDevDevice device, input_event ev)
        {
            if (ev.type == (short)EvType.EV_REL)
            {
                if (ev.code == (short)AxisEventCode.REL_X)
                    _x = Math.Min(_width, Math.Max(0, _x + ev.value));
                else if (ev.code == (short)AxisEventCode.REL_Y)
                    _y = Math.Min(_height, Math.Max(0, _y + ev.value));
                else
                    return;
                Console.WriteLine($"relative x->{_x} y->{_y}");
            }
            else if (ev.type == (int)EvType.EV_ABS)
            {
                if (ev.code == (short)AbsAxis.ABS_X && device.AbsX.HasValue)
                    _x = TranslateAxis(device.AbsX.Value, ev.value, _width);
                else if (ev.code == (short)AbsAxis.ABS_Y && device.AbsY.HasValue)
                    _y = TranslateAxis(device.AbsY.Value, ev.value, _height);
                else
                    return;

                Console.WriteLine($"absolute x->{_x} y->{_y}");
            }
            else if (ev.type == (short)EvType.EV_KEY)
            {
                RawMouseEventType? type = null;
                if (ev.code == (ushort)EvKey.BTN_LEFT)
                    type = ev.value == 1 ? RawMouseEventType.LeftButtonDown : RawMouseEventType.LeftButtonUp;
                if (ev.code == (ushort)EvKey.BTN_RIGHT)
                    type = ev.value == 1 ? RawMouseEventType.RightButtonDown : RawMouseEventType.RightButtonUp;
                if (ev.code == (ushort)EvKey.BTN_MIDDLE)
                    type = ev.value == 1 ? RawMouseEventType.MiddleButtonDown : RawMouseEventType.MiddleButtonUp;
                if (!type.HasValue)
                    return;

                Console.WriteLine($"key button->{type}");
            }
            else
            {
                Console.WriteLine($"other type->{(EvType)ev.type} code->{ev.code} value->{ev.value}");
            }

        }
    }
}

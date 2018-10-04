using System;
using System.Runtime.InteropServices;
using __s32 = System.Int32;
using __u16 = System.UInt16;
using __u32 = System.UInt32;

namespace Avalonia.LinuxFramebuffer
{
    unsafe class NativeUnsafeMethods
    {
        [DllImport("libc", EntryPoint = "open", SetLastError = true)]
        public static extern int open(string pathname, int flags, int mode);

        [DllImport("libc", EntryPoint = "close", SetLastError = true)]
        public static extern int close(int fd);

        [DllImport("libevdev.so.2", EntryPoint = "libevdev_new_from_fd", SetLastError = true)]
        public static extern int libevdev_new_from_fd(int fd, out IntPtr dev);

        [DllImport("libevdev.so.2", EntryPoint = "libevdev_has_event_type", SetLastError = true)]
        public static extern int libevdev_has_event_type(IntPtr dev, EvType type);

        [DllImport("libevdev.so.2", EntryPoint = "libevdev_next_event", SetLastError = true)]
        public static extern int libevdev_next_event(IntPtr dev, int flags, out input_event ev);

        [DllImport("libevdev.so.2", EntryPoint = "libevdev_get_name", SetLastError = true)]
        public static extern IntPtr libevdev_get_name(IntPtr dev);
        [DllImport("libevdev.so.2", EntryPoint = "libevdev_get_abs_info", SetLastError = true)]
        public static extern input_absinfo* libevdev_get_abs_info(IntPtr dev, int code);
    }

    enum EvType
    {
        EV_SYN = 0x00,
        EV_KEY = 0x01,
        EV_REL = 0x02,
        EV_ABS = 0x03,
        EV_MSC = 0x04,
        EV_SW = 0x05,
        EV_LED = 0x11,
        EV_SND = 0x12,
        EV_REP = 0x14,
        EV_FF = 0x15,
        EV_PWR = 0x16,
        EV_FF_STATUS = 0x17,
    }

    [StructLayout(LayoutKind.Sequential)]
    struct input_event
    {
        private IntPtr crap1, crap2;
        public ushort type, code;
        public int value;
    }

    enum AxisEventCode
    {
        REL_X = 0x00,
        REL_Y = 0x01,
        REL_Z = 0x02,
        REL_RX = 0x03,
        REL_RY = 0x04,
        REL_RZ = 0x05,
        REL_HWHEEL = 0x06,
        REL_DIAL = 0x07,
        REL_WHEEL = 0x08,
        REL_MISC = 0x09,
        REL_MAX = 0x0f
    }

    enum AbsAxis
    {
        ABS_X = 0x00,
        ABS_Y = 0x01,
        ABS_Z = 0x02,
        ABS_RX = 0x03,
        ABS_RY = 0x04,
        ABS_RZ = 0x05,
        ABS_THROTTLE = 0x06,
        ABS_RUDDER = 0x07,
        ABS_WHEEL = 0x08,
        ABS_GAS = 0x09,
        ABS_BRAKE = 0x0a,
        ABS_HAT0X = 0x10,
        ABS_HAT0Y = 0x11,
        ABS_HAT1X = 0x12,
        ABS_HAT1Y = 0x13,
        ABS_HAT2X = 0x14,
        ABS_HAT2Y = 0x15,
        ABS_HAT3X = 0x16,
        ABS_HAT3Y = 0x17,
        ABS_PRESSURE = 0x18,
        ABS_DISTANCE = 0x19,
        ABS_TILT_X = 0x1a,
        ABS_TILT_Y = 0x1b,
        ABS_TOOL_WIDTH = 0x1c
    }

    enum EvKey
    {
        BTN_LEFT = 0x110,
        BTN_RIGHT = 0x111,
        BTN_MIDDLE = 0x112
    }

    [StructLayout(LayoutKind.Sequential)]
    struct input_absinfo
    {
        public __s32 value;
        public __s32 minimum;
        public __s32 maximum;
        public __s32 fuzz;
        public __s32 flat;
        public __s32 resolution;

    }
}

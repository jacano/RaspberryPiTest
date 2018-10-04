using Avalonia.LinuxFramebuffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main()
        {
            var mouseDevices = EvDevDevice.MouseDevices.Where(d => d.IsMouse).ToList();
            foreach (var mice in mouseDevices)
            {
                Console.WriteLine($"mouse: {mice.Name}");
            }
        }
    }
}

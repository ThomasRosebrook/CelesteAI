using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace CelesteAI.CelesteData
{
    public static class Inputs
    {
        static InputSimulator InputSimulator = new InputSimulator();

        public static void holdKey(VirtualKeyCode k, int i)
        {
            //VirtualKeyCode keyCode = VirtualKeyCode.VK_W;
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
        }

        public static void updown(VirtualKeyCode k)
        {
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(30);
            InputSimulator.Keyboard.KeyUp(k);
        }

        public static void holdTwoKeys(VirtualKeyCode k, VirtualKeyCode k2, int i)
        {
            InputSimulator.Keyboard.KeyDown(k);
            InputSimulator.Keyboard.KeyDown(k2);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
            InputSimulator.Keyboard.KeyUp(k2);
        }
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void openCeleste()
        {
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("celeste"); //search for process celeste
            if (p.Length > 0) //check if window was found
            {
                SetForegroundWindow(p[0].MainWindowHandle); //bring celeste to foreground
            }

        }
    }
}

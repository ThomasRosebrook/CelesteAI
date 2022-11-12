using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;

namespace CeletseAI
{
    public class Inputs
    {
        public void holdKey(VirtualKeyCode k, int i)
        {

            InputSimulator InputSimulator = new InputSimulator();
            //VirtualKeyCode keyCode = VirtualKeyCode.VK_W;
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
        }
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public void openCeleste()
        {
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("celeste"); //search for process celeste
            if (p.Length > 0) //check if window was found
            {
                SetForegroundWindow(p[0].MainWindowHandle); //bring celeste to foreground
            }

        }
    }
}

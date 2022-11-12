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
        InputSimulator InputSimulator = new InputSimulator();
        public void holdKey(VirtualKeyCode k, int i)
        {
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
        }
        public void updown(VirtualKeyCode k)
        {
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(30);
            InputSimulator.Keyboard.KeyUp(k);
        }
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// brings the game celeste to the first window
        /// </summary>
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

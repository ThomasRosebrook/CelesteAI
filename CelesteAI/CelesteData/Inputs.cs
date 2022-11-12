﻿using System;
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
        public static void holdKey(VirtualKeyCode k, int i)
        {

            InputSimulator InputSimulator = new InputSimulator();
            //VirtualKeyCode keyCode = VirtualKeyCode.VK_W;
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
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
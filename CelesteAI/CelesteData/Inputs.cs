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
        static InputSimulator InputSimulator = new InputSimulator();

        /// <summary>
        /// Holds down a given key for a specified amount of time
        /// </summary>
        /// <param name="k">The key to press down</param>
        /// <param name="i">The amount of time to press the key down for</param>
        public static void holdKey(VirtualKeyCode k, int i)
        {
            //VirtualKeyCode keyCode = VirtualKeyCode.VK_W;
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
        }

        /// <summary>
        /// holdKey for menu movement
        /// </summary>
        /// <param name="k">The button to press on the keyboard</param>
        public static void updown(VirtualKeyCode k)
        {
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(30);
            InputSimulator.Keyboard.KeyUp(k);
        }

        /// <summary>
        /// Holds down two given keys for a specified amount of time
        /// </summary>
        /// <param name="k">The first key to press down</param>
        /// <param name="k2">The second key to press down</param>
        /// <param name="i">The amount of time to press the keys down for</param>
        public static void holdTwoKeys(VirtualKeyCode k, VirtualKeyCode k2, int i)
        {
            InputSimulator.Keyboard.KeyDown(k);
            InputSimulator.Keyboard.KeyDown(k2);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
            InputSimulator.Keyboard.KeyUp(k2);
        }

        /// <summary>
        /// Resets the Celeste room
        /// </summary>
        public static void ResetRoom ()
        {
            Inputs.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2000);
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

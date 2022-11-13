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
        /// Holds down three given keys for a specified amount of time
        /// </summary>
        /// <param name="k">The first key to press down</param>
        /// <param name="k2">The second key to press down</param>
        /// <param name="k3">The third key to press down</param>
        /// <param name="i">The amount of time to press the keys down for</param>
        public static void holdThreeKeys(VirtualKeyCode k, VirtualKeyCode k2, VirtualKeyCode k3, int i)
        {
            InputSimulator.Keyboard.KeyDown(k);
            InputSimulator.Keyboard.KeyDown(k2);
            InputSimulator.Keyboard.KeyDown(k3);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
            InputSimulator.Keyboard.KeyUp(k2);
            InputSimulator.Keyboard.KeyUp(k3);
        }

        /// <summary>
        /// Holds down four given keys for a specified amount of time
        /// </summary>
        /// <param name="k">The first key to press down</param>
        /// <param name="k2">The second key to press down</param>
        /// <param name="k3">The third key to press down</param>
        /// <param name="k4">The fourth key to press down</param>
        /// <param name="i">The amount of time to press the keys down for</param>
        public static void holdFourKeys(VirtualKeyCode k, VirtualKeyCode k2, VirtualKeyCode k3, VirtualKeyCode k4, int i)
        {
            InputSimulator.Keyboard.KeyDown(k);
            InputSimulator.Keyboard.KeyDown(k2);
            InputSimulator.Keyboard.KeyDown(k3);
            InputSimulator.Keyboard.KeyDown(k4);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
            InputSimulator.Keyboard.KeyUp(k2);
            InputSimulator.Keyboard.KeyUp(k3);
            InputSimulator.Keyboard.KeyUp(k4);
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

        /// <summary>
        /// Moves to a given side and chapter in the menu and selects it
        /// </summary>
        /// <param name="chapterNum">The number of the chapter (Prologue = 0)</param>
        /// <param name="sideNum">The number of the side (A = 0, B = 1, C = 2)</param>
        public static void LevelSelect(int chapterNum, int sideNum)
        {
            for (int i = 0; i < 11; i++)
            {
                updown(VirtualKeyCode.LEFT);
                Thread.Sleep(250);
            }

            for (int i = 0; i < chapterNum; i++)
            {
                updown(VirtualKeyCode.RIGHT);
                Thread.Sleep(250);
            }

            Thread.Sleep(500);
            updown(VirtualKeyCode.VK_C);
            Thread.Sleep(750);

            for (int i = 0; i < sideNum; i++)
            {
                updown(VirtualKeyCode.RIGHT);
                Thread.Sleep(30);
            }

            Thread.Sleep(250);
            updown(VirtualKeyCode.VK_C);
            Thread.Sleep(750);
            updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2500);
            if (chapterNum == 0)
            {
                Inputs.updown(VirtualKeyCode.RETURN);
                Thread.Sleep(50);
                Inputs.updown(VirtualKeyCode.DOWN);
                Thread.Sleep(50);
                Inputs.updown(VirtualKeyCode.VK_C);
                Thread.Sleep(2500);
            }
            
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

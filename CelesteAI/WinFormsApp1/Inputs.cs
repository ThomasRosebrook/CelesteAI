using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace CeletseAI
{
    public class Inputs
    {
        /// <summary>
        /// holds down a key for a specific time
        /// </summary>
        /// <param name="k">the key</param>
        /// <param name="i">time</param>
        public void holdKey(VirtualKeyCode k, int i)
        {
            InputSimulator InputSimulator = new InputSimulator();
            //VirtualKeyCode keyCode = VirtualKeyCode.VK_W;
            InputSimulator.Keyboard.KeyDown(k);
            Thread.Sleep(i);
            InputSimulator.Keyboard.KeyUp(k);
        }
    }
}

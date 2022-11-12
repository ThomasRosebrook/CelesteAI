using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace CeletseAI
{
    public class levels
    {
        Inputs i = new Inputs();
        InputSimulator IS = new InputSimulator();
        const decimal convert = 1000.0m / 60.0m;
        public void chapter0()
        {
            
            Thread.Sleep(1000);
            i.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(4000);
            i.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            i.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            i.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2000);
            i.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            i.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            i.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2000);

            IS.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
            Thread.Sleep((int)(32 * convert));
            i.holdKey(VirtualKeyCode.VK_C, (int)(35 * convert));
            Thread.Sleep((int)(23 * convert));
            i.holdKey(VirtualKeyCode.VK_C, (int)(36 * convert));
            Thread.Sleep((int)(7 * convert));
            i.holdKey(VirtualKeyCode.VK_C, (int)(30 * convert));
            Thread.Sleep((int)(32 * convert));
            i.holdKey(VirtualKeyCode.VK_C, (int)(22* convert));
            Thread.Sleep((int)(74 * convert));
            IS.Keyboard.KeyUp(VirtualKeyCode.RIGHT);


        }
    }
}

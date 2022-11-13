using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace CelesteAI.CelesteData
{
    public static class AIRuns
    {

        const decimal convert = 1000.0m / 60.0m;
        static InputSimulator InputSimulator = new InputSimulator();

        public static void RunPrologue()
        {
            //Start and Skip Cutscene
            Thread.Sleep(1000);
            Inputs.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2500);
            Inputs.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2500);

            //Room 1
            InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
            Thread.Sleep((int)(42 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(14 * convert));
            Thread.Sleep((int)(31 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(23 * convert));
            Thread.Sleep((int)(30 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(7 * convert));
            Thread.Sleep((int)(48 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(32 * convert));
            Thread.Sleep((int)(65 * convert));
            InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);

            //Room 2
            Thread.Sleep(500); //Room Transition
            InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(39 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(15 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(18 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(12 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(5 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(11 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(7 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(8 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(13 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(13 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(6 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(29 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(19 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(5 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(10 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(4 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(7 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(5 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(35 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(4 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(27 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(10 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(20 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(17 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(5 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(7 * convert));
            Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(6 * convert));
            Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(9 * convert));
            Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(37 * convert));
            InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);

            //Room 3 & 4
            Thread.Sleep(500); //Room Transition
            InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
            Thread.Sleep((int)(17 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(15 * convert));
            Thread.Sleep((int)(10 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(22 * convert));
            Thread.Sleep((int)(38 * convert));
            
            //Grandma Cutscene Skip
            Inputs.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(200);

            Thread.Sleep((int)(447 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(6 * convert));
            Thread.Sleep((int)(189 * convert));
            Inputs.holdKey(VirtualKeyCode.VK_C, (int)(15 * convert));
            Thread.Sleep((int)(50 * convert));
            InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
            
            //Dash Tutorial Cutscene Skip
            Inputs.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.VK_C);
        }
        public static void RunChapter1(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    /*
                    //Checkpoint 1
                    //Room 1
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(15 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(18 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(13 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, VirtualKeyCode.VK_C, (int)(13 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(20 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, VirtualKeyCode.VK_C, (int)(11 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(30 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(27 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(41 * convert));

                    //Room 2
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(35 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(45 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(12 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(47 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(12 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(135 * convert));


                    //Room 3
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(6 * convert));
                    Thread.Sleep((int)(22 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(22 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(13 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(30 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(18 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(7 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(14 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(19 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(13 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(8 * convert));
                    
                    //Room 4
                    Thread.Sleep(1000);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(22 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(11 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(64 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(38 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(10 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(30 * convert));

                    //Room 5
                    Thread.Sleep(1000);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(21 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(29 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(14 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(5 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(29 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(15 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(15 * convert));

                    //Room 6
                    Thread.Sleep(1250);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(16 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(18 * convert));
                    Thread.Sleep((int)(29 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(26 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(29 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(26 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(7 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(8 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(45 * convert));

                    //2nd Checkpoint
                    //Room 7
                    Thread.Sleep(1250);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(9 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_Z, VirtualKeyCode.UP, (int)(8 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(1 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.VK_C, VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(7 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, VirtualKeyCode.LEFT, (int)(9 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(4 * convert));
                    //Inputs.holdKey(VirtualKeyCode.LEFT, (int)(1 * convert));
                    Thread.Sleep(3);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(1 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(22 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(48 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(13 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(20 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(47 * convert));

                    //Room 8
                    Thread.Sleep(1000);
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Thread.Sleep(2);
                    Inputs.holdTwoKeys(VirtualKeyCode.DOWN, VirtualKeyCode.LEFT, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.DOWN, VirtualKeyCode.LEFT, VirtualKeyCode.VK_X, (int)(10 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.DOWN, VirtualKeyCode.LEFT, (int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.RIGHT, (int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(35 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(7 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_X, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_X, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_X, VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.LEFT, (int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_C, VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(13 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(26 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(7 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(115 * convert));


                    //Room 9
                    Thread.Sleep(1000);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(6 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(20 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(19 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(13 * convert));
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(15 * convert));
                    Thread.Sleep((int)(29 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(11 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X,  (int)(13 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(21 * convert));
                    Thread.Sleep(27);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(6 * convert));

                    //Room 10
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(9 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(12 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(12 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(17 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, (int)(38 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(14 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(18 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(28 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(12 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(7 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(4 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(5 * convert));

                    //Room 11
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(14 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(35 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(21 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(24 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(9 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(14 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(12 * convert));
                    Thread.Sleep((int)(7 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(13 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(7 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(18 * convert));

                    //Room 12
                    Thread.Sleep(1150);
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(5 * convert));
                    Thread.Sleep((int)(12 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.DOWN, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(27 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(16 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(17 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(14 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(13 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(12 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(36 * convert));

                    //Room 13
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(45 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(33 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(34 * convert));
                    Thread.Sleep((int)(7 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Thread.Sleep((int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(8 * convert));

                    //Room 14
                    Thread.Sleep(1000);
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(2 * convert));
                    Thread.Sleep((int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_X, (int)(6 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(25 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(19 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(28 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, VirtualKeyCode.VK_C, (int)(11 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(10 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(9 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_X, (int)(3 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_X, VirtualKeyCode.VK_C, (int)(11 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(6 * convert));
                    */
                    //Checkpoint 3

                    //Room 15
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(18 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(13 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(4 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(30 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(5 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_Z, (int)(22 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(5 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(20 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(6 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(8 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(7 * convert));
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(2 * convert));


                    //Room 16
                    Thread.Sleep(1000);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(15 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(4 * convert));
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_X, VirtualKeyCode.UP, (int)(6 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(8 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_C, VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.RIGHT, (int)(15 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_C, VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.VK_X, VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(10 * convert));
                    Thread.Sleep((int)(29 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_X, (int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(34 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(13 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(28 * convert));
                    Thread.Sleep((int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(15 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_X, VirtualKeyCode.UP, (int)(10 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(8 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(6 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(5 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(7 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(10 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(8 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(2 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.UP, (int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(3 * convert));

                    //Room 17
                    Thread.Sleep(500);
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.VK_C, VirtualKeyCode.LEFT, (int)(24 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(16 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_Z, (int)(1 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(14 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, VirtualKeyCode.RIGHT, (int)(5 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_X, (int)(11 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(4 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_Z, (int)(13 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_Z, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_Z, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_Z, (int)(14 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_Z, (int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(27 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.DOWN, (int)(4 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_X, (int)(1 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.LEFT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_X, VirtualKeyCode.VK_C, (int)(16 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.LEFT, VirtualKeyCode.DOWN, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.DOWN, (int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(23 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_X, (int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(20 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.LEFT, VirtualKeyCode.VK_C, (int)(8 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(1 * convert));
                    Thread.Sleep((int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(10 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, (int)(1 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, 11);
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(9 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_Z, VirtualKeyCode.VK_X, (int)(12 * convert));
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter2(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    //room 1
                    Thread.Sleep(500);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(14 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(22 * convert));
                    Thread.Sleep((int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(15 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Inputs.holdKey(VirtualKeyCode.UP, (int)(100 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(2 * convert));
                    Thread.Sleep((int)(45 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep(1000);

                    //room 2
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(100 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(26 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(35 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Inputs.holdTwoKeys(VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(28 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(34 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(11 * convert));
                    Thread.Sleep((int)(58 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    Thread.Sleep((int)(3 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(8 * convert));
                    Thread.Sleep((int)(17 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(4 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    Thread.Sleep((int)(25 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(13 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(5 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    Thread.Sleep((int)(13 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(3 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(22 * convert));
                    Thread.Sleep((int)(27 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(23 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(14 * convert));
                    Thread.Sleep((int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(12 * convert));
                    Thread.Sleep((int)(143 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep(500);

                    //room 3
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(23 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                    Thread.Sleep((int)(23 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_X);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                    Thread.Sleep((int)(9 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_X);
                    Thread.Sleep((int)(18 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(43 * convert));
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(2 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(2 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(9 * convert));
                    Thread.Sleep((int)(9 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(18 * convert));
                    Thread.Sleep((int)(15 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(7 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(20 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(23 * convert));
                    Thread.Sleep((int)(46 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                    Thread.Sleep((int)(38 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    Thread.Sleep((int)(3 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(12 * convert));
                    Thread.Sleep((int)(7 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    Thread.Sleep((int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(15 * convert));
                    Thread.Sleep((int)(20 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(10 * convert));
                    Thread.Sleep((int)(7 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(10 * convert));
                    Thread.Sleep((int)(2 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(2 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(10 * convert));
                    Thread.Sleep((int)(25 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(21 * convert));
                    Thread.Sleep((int)(4 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(27 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(20 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(9 * convert));
                    Thread.Sleep((int)(9 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(6 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(8 * convert));
                    Thread.Sleep((int)(3 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    Thread.Sleep((int)(19 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(9 * convert));
                    Thread.Sleep((int)(35 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(9 * convert));
                    Thread.Sleep((int)(6 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(1 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    Thread.Sleep((int)(25 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(10 * convert));
                    Thread.Sleep((int)(6 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    Thread.Sleep((int)(2 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(39 * convert));
                    Thread.Sleep((int)(5 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(44 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    Thread.Sleep((int)(7 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(8 * convert));
                    Thread.Sleep((int)(28 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(7 * convert));
                    Thread.Sleep((int)(15 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(7 * convert));
                    Thread.Sleep((int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(4 * convert));
                    Thread.Sleep((int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(5 * convert));
                    Thread.Sleep((int)(15 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(8 * convert));
                    Thread.Sleep((int)(18 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_X, (int)(6 * convert));
                    Thread.Sleep((int)(15 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                    Thread.Sleep((int)(22 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    Thread.Sleep((int)(4 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                    Thread.Sleep((int)(9 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    Thread.Sleep((int)(13 * convert));
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Thread.Sleep((int)(41 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(11 * convert));
                    Thread.Sleep((int)(12 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    Thread.Sleep((int)(4 * convert));
                    Inputs.holdKey(VirtualKeyCode.VK_C, (int)(10 * convert));
                    Thread.Sleep((int)(120 * convert));
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    for (int i = 0; i < 10; i++)
                    {
                        Inputs.holdKey(VirtualKeyCode.LEFT, (int)(3 * convert));
                        Thread.Sleep((int)(2 * convert));
                        Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(2 * convert));
                        Thread.Sleep((int)(2 * convert));
                    }
                    break;

            }
        }
        public static void RunChapter3(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter4(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                  break;
                    
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter5(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    //Room 7
                    Thread.Sleep(1250);
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(3 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(15 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(14 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, (int)(21 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.LEFT, VirtualKeyCode.UP, VirtualKeyCode.VK_Z, VirtualKeyCode.VK_C, (int)(17 * convert));
                    Inputs.holdKey(VirtualKeyCode.LEFT, (int)(6 * convert));
                    Thread.Sleep((int)(5 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(7 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, (int)(21 * convert));
                    Inputs.holdFourKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(20 * convert));
                    Thread.Sleep((int)(10 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(21 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.VK_X, (int)(19 * convert));
                    Inputs.holdKey(VirtualKeyCode.RIGHT, (int)(15 * convert));
                    Inputs.holdTwoKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, (int)(17 * convert));
                    Inputs.holdThreeKeys(VirtualKeyCode.RIGHT, VirtualKeyCode.VK_C, VirtualKeyCode.VK_X, (int)(10 * convert));
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter6(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter7(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunEpilogue()
        {

        }

        public static void RunChapter8(Sides s)
        {
            switch (s)
            {
                case Sides.A:
                    break;
                case Sides.B:
                    break;
                case Sides.C:
                    break;

            }
        }

        public static void RunChapter9()
        {

        }

        public static void RunAllChapters()
        {
            RunPrologue();
            RunChapter1(Sides.A);
            RunChapter2(Sides.A);
            RunChapter3(Sides.A);
            RunChapter4(Sides.A);
            RunChapter5(Sides.A);
            RunChapter6(Sides.A);
            RunChapter7(Sides.A);
        }
        public static void RunAI(Chapters Chapter, Sides side)
        {
            Inputs.openCeleste();
            switch (Chapter)
            {
                case Chapters.Prologue:
                    //Inputs.LevelSelect(0, 0);
                    RunPrologue();
                    break;
                case Chapters.ForsakenCity:
                    //Inputs.LevelSelect(1, (int)side);
                    RunChapter1(side);
                    break;
                case Chapters.OldSite:
                    //Inputs.LevelSelect(2, (int)side);
                    RunChapter2(side);
                    break;
                case Chapters.CelestialResort:
                    //Inputs.LevelSelect(3, (int)side);
                    RunChapter3(side);
                    break;
                case Chapters.GoldenRidge:
                    //Inputs.LevelSelect(4, (int)side);
                    RunChapter4(side);
                    break;
                case Chapters.MirrorTemple:
                    //Inputs.LevelSelect(5, (int)side);
                    RunChapter5(side);
                    break;
                case Chapters.Reflection:
                    Inputs.LevelSelect(6, (int)side);
                    RunChapter6(side);
                    break;
                case Chapters.TheSummit:
                    Inputs.LevelSelect(7, (int)side);
                    RunChapter7(side);
                    break;
                case Chapters.Epilogue:
                    Inputs.LevelSelect(8, (int)side);
                    RunEpilogue();
                    break;
                case Chapters.All:
                    Inputs.LevelSelect(9, (int)side);
                    RunAllChapters();
                    break;
                case Chapters.Core:
                    Inputs.LevelSelect(10, (int)side);
                    RunChapter8(side);
                    break;
                case Chapters.Farewell:
                    Inputs.LevelSelect(11, (int)side);
                    RunChapter9();
                    break;
                default:
                    break;
            }
        }
    }
}

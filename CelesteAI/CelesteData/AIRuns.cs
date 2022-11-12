using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;

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
            /*
            //Reset Room
            Inputs.updown(VirtualKeyCode.RETURN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.DOWN);
            Thread.Sleep(50);
            Inputs.updown(VirtualKeyCode.VK_C);
            Thread.Sleep(2500);
            */
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
        }
        public static void RunChapter1()
        {

        }

        public static void RunChapter2()
        {

        }
        public static void RunChapter3()
        {

        }

        public static void RunChapter4()
        {

        }

        public static void RunChapter5()
        {

        }

        public static void RunChapter6()
        {

        }

        public static void RunChapter7()
        {

        }

        public static void RunEpilogue()
        {

        }

        public static void RunChapter8()
        {

        }

        public static void RunChapter9()
        {

        }

        public static void RunAI(Chapters Chapter)
        {
            Inputs.openCeleste();

            switch (Chapter)
            {
                case Chapters.Prologue:
                    RunPrologue();
                    break;
                case Chapters.ForsakenCity:
                    RunChapter1();
                    break;
                case Chapters.OldSite:
                    RunChapter2();
                    break;
                case Chapters.CelestialResort:
                    RunChapter3();
                    break;
                case Chapters.GoldenRidge:
                    RunChapter4();
                    break;
                case Chapters.MirrorTemple:
                    RunChapter5();
                    break;
                case Chapters.Reflection:
                    RunChapter6();
                    break;
                case Chapters.TheSummit:
                    RunChapter7();
                    break;
                case Chapters.Epilogue:
                    RunEpilogue();
                    break;
                case Chapters.Core:
                    RunChapter8();
                    break;
                case Chapters.Farewell:
                    RunChapter9();
                    break;
                default:
                    break;
            }
        }

    }
}

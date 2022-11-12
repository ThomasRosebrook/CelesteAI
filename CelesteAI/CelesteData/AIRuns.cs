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

            Inputs.ResetRoom();

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
        //0 = A Side 
        //1 = B Side
        //2 = C Side
        public static void RunChapter1(Sides s)
        {
        }

        public static void RunChapter2(Sides s)
        {..

        }
        public static void RunChapter3(Sides s)
        {

        }

        public static void RunChapter4(Sides s)
        {

        }

        public static void RunChapter5(Sides s)
        {

        }

        public static void RunChapter6(Sides s)
        {

        }

        public static void RunChapter7(Sides s)
        {

        }

        public static void RunEpilogue()
        {

        }

        public static void RunChapter8(Sides s)
        {

        }

        public static void RunChapter9(Sides s)
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
        public static void runOneLevel(Chapters Chapter, Sides side)
        {
            Inputs.openCeleste();
            switch (Chapter)
            {
                case Chapters.Prologue:
                    RunPrologue();
                    break;
                case Chapters.ForsakenCity:
                    RunChapter1(side);
                    break;
                case Chapters.OldSite:
                    RunChapter2(side);
                    break;
                case Chapters.CelestialResort:
                    RunChapter3(side);
                    break;
                case Chapters.GoldenRidge:
                    RunChapter4(side);
                    break;
                case Chapters.MirrorTemple:
                    RunChapter5(side);
                    break;
                case Chapters.Reflection:
                    RunChapter6(side);
                    break;
                case Chapters.TheSummit:
                    RunChapter7(side);
                    break;
                case Chapters.Epilogue:
                    RunEpilogue();
                    break;
                case Chapters.All:
                    RunAllChapters();
                    break;
                default:
                    break;
            }
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
                case Chapters.All:
                    RunAllChapters();
                    break;
                default:
                    break;
            }
        }
    }
}

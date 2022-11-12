﻿using System;
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
        //0 = A Side 
        //1 = B Side
        //2 = C Side
        public static void RunChapter1(Sides s)
        {

        }

        public static void RunChapter2(Sides s)
        {

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
        public static void RunAI(Chapters Chapter, Sides side)
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
    }
}

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
        public static void RunPrologue()
        {
            
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

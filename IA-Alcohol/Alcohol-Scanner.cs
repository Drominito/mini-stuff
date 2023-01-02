using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaveMoves;
using static WaveMoves.Programm;

namespace IA_Alcohol
{
    
    internal class Program
    {
        static public void Redcolor(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input);
            Console.ResetColor();
        }
        static public void Yellowcolor(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(input);
            Console.ResetColor();
        }
        static void Startscreen()
        {
            Console.WriteLine("|-|----START----SCREEN----|-|");
        }
        static void Main()
        {
            Startscreen();
            Console.ReadKey();
            Console.Clear();



            Console.Write("|");     Redcolor("German");     Console.Write("|       |");     Yellowcolor("ENGLISH"); Console.Write("|");     Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("|  1   |       |   2   |");

            Console.WriteLine();

            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                GermanMain();
            }
            else
            {
                EnglishMain();
            }




        }
        static void GermanMain()
        {
            AlcoholTestClassUniversal T = new AlcoholTestClassUniversal();
            T.AlcoholScannerGerman += OutputGerman;
            Console.Write("Sie Fahren mit dem Auto nach Hause direkt von der Arbeit");
            string dot_text = ".";
            for (int i = 0; i < dot_text.Length * 3; i++)
            {

                Thread.Sleep(1000);
                Console.Write(dot_text);
            }


            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("Sie wurden vom Polizisten angehalten");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hallo ich müsse sie kurz ein Alkohol test durchführen :)");
            Thread.Sleep(2000);

            Console.ReadKey();
            Console.Write("Gebe deine GlückZahl ein: ");
            int ReadLine_input = int.Parse(Console.ReadLine());
            Console.ReadKey();

            T.OnAlcoholScannerGerman(ReadLine_input);

            Console.ReadKey();
        }
        static void EnglishMain()
        {
            AlcoholTestClassUniversal T = new AlcoholTestClassUniversal();
            T.AlcoholScannerEnglish += OutputEnglish;
            Console.Write("I drive my car home from work");
            string dot_text = ".";
            for (int i = 0; i < dot_text.Length * 3; i++)
            {

                Thread.Sleep(1000);
                Console.Write(dot_text);
            }


            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("you were stopped by the police");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hello, I have to do a breathalyzer test for you :)");
            Thread.Sleep(2000);

            Console.ReadKey();
            Console.Write("enter your lucky number: ");
            int ReadLine_input = int.Parse(Console.ReadLine());
            Console.ReadKey();

            T.OnAlcoholScannerEnglish(ReadLine_input);

            Console.ReadKey();
            
        }
        static void OutputGerman(int InputGerman)
        {
            
            if (InputGerman % 2 == 0)
            {
                Console.WriteLine("Sie wurden Gescannt.");
            }
            else
            {
                  
                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alarm!!");
                }
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
                Programm.Main();
            }
            
        }
        static void OutputEnglish(int InputEnglish)
        {

            if (InputEnglish % 2 == 0)
            {
                Console.WriteLine("you have been scanned.");
                Console.ReadKey();
            }
            else
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alarm!!");
                }
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
                Programm.Main();
            }

        }
    }
    class AlcoholTestClassUniversal
    {
        public delegate void AlcoholTestGerman(int DInputGerman);
        public event AlcoholTestGerman AlcoholScannerGerman;




        public delegate void AlcoholTestEnglish(int DInputEnglish);
        public event AlcoholTestEnglish AlcoholScannerEnglish;

        public void OnAlcoholScannerGerman(int EinputGerman)
        {
            if (AlcoholScannerGerman != null)
            {
                AlcoholScannerGerman(EinputGerman);
            }
        }
        public void OnAlcoholScannerEnglish(int EinputEnglish)
        {
            if (AlcoholScannerEnglish != null) // oh com on man, the biggest error was that, that here was "AlcoholScannerGerman" and not "AlcoholScannerEnglich".  I spend over 30 minutes to fix it
            {
                AlcoholScannerEnglish(EinputEnglish);
            }
        }


    }

    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            global::System.Console.WriteLine("Hello World");
            Console.ReadKey();

        }
        static void MainMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("###########\n##HANGMAN##\n###########");

                Console.WriteLine("Game Start      Leave Game ");
                Console.Write("Wäle eine Aktion aus: ");
                Console.WriteLine("Aktion [1]\n\t\t      Aktion [2]");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    array();
                    break;
                }
                else
                {
                    Console.WriteLine("Adios");
                    break;
                }
            }
        }
        static void array()
        {
            string[] words = new string[]
            {
                "Hallo",
                "Alexa",
                "Mirofon",
                "Programmieren",
                "Monitor",


            };
            Random random = new Random();
            int index = random.Next(0, words.Length);
            string word = words[index].ToLower();
            GameMechaniks(word);
        }
        static void GameMechaniks(string word)
        {
            int lives = 5;
            string hiddenword = "";

            for (int i = 0; i < word.Length; i++)
            {
                hiddenword += "_";
            }

            while (true)
            {
                Console.Clear();
                Console.Write($"Gesuchtes Word: {hiddenword}");
                Console.WriteLine();
                Console.Write("Noch übrige versuche");

                for (int i = 0; i < lives; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("<3   ");
                    Console.ResetColor();
                }
                Console.WriteLine();
                char character = Convert.ToChar(Console.ReadLine().ToLower());
                bool foundcharacterinWord = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (character == word[i])
                    {
                        foundcharacterinWord = true;
                        break;
                    }
                   
                }
                if (foundcharacterinWord)
                {
                    string Temphiddenword = hiddenword;
                    hiddenword = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (character == word[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            hiddenword += character;
                            Console.ResetColor();
                        }
                        else if (Temphiddenword[i] != '_')
                        {
                            hiddenword += Temphiddenword[i];
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            hiddenword += '_';
                            Console.ResetColor();
                        }
                    }
                   if (hiddenword == word)
                   {
                        Console.Clear();
                        Console.WriteLine($"du hast gewonnen! das wort war {word}");
                        break;
                   }
                }
                else
                {
                    lives -= 1;
                    if (lives == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("DU HAST VERLOREN!!!");
                        break;
                    }
                }
               
            }   

            Console.ReadKey();

            
        }

    }
}

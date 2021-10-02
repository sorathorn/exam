using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum Menu
{
    Play = 1,
    Exist
}

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            //ใส่คำศัพท์ให้ทาย
            string[] listwords = new string[3];
            listwords[0] = "tennis";
            listwords[1] = "football";
            listwords[2] = "badminton";
            Random number = new Random();
            var dimention = number.Next(0, 3);
            string secretWord = listwords[dimention];
            char[] guess = new char[secretWord.Length];
            PlayGame();

            for (int p = 0; p < secretWord.Length; p++)
                guess[p] = '_';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < secretWord.Length; j++)
                {
                    if (playerGuess == secretWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
            static void Header()
            {
                //หน้าเริ่มต้น
                Console.WriteLine("Welcome to Hangman Game");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Play Game");
                Console.WriteLine("Exist");
                Console.Write("Please Select Menu: ");
            }
            static void PlayGame()
            {
                //หน้าเกม
                Console.WriteLine("Play Game Hangman");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Incorrect Score: 0");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Input letter alphabet");
            }

        }
    }
}
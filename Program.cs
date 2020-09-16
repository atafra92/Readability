﻿using System;
using System.Linq;

namespace readability
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your String: ");
            string text = Console.ReadLine();


            int numberOfLetters = 0;
            foreach (char letter in text)
            {
                bool isLetter = char.IsLetter(letter);
                if (isLetter)
                    numberOfLetters++;
            }


            
            int numberOfWords = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(text[i]) == true ||
                        char.IsPunctuation(text[i]))
                    {
                        numberOfWords ++;
                    }
                }
            }
            if (text.Length > 2)
            {
                numberOfWords++;
            }

            
            int numberOfSentences = 0;
            for (int i = 1; i < text.Length; i++)
            {

                if (text[i] == '.' || text[i] == '!' || text[i] == '?')

                    numberOfSentences++;
            }

            double L =  100*numberOfLetters/numberOfWords;
            double S =  100*numberOfSentences/numberOfWords;

            double index = (0.0588 * L) - (0.296 * S) - 15.8;
            int grade = Convert.ToInt32(Math.Round(index));
            
            if (grade < 1)
                Console.Write("Before Grade 1");
            
            else if (grade >= 16)
                Console.Write(" Grade 16+");
            else
                Console.WriteLine("Grade: {0}", grade);

           // Console.Write("number of letters: {0}\nnumber of words: {1}\nnumber of Sentences: {2}\nGrade: {3}", numberOfLetters, numberOfWords, numberOfSentences, grade);
            Console.ReadLine();
        }
    }
}


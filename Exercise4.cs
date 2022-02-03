using System;

namespace patika_algorithm_exercises
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            //? In a console application, ask the user to type a sentence.
            //? Print the total number of words and letters in the sentence to the console.

            Console.WriteLine("Please enter a sentence:");
            string sentence=Console.ReadLine();
            string[] partedWords=sentence.Split(" ");
            char[] words=sentence.ToCharArray();

            int TotalWordCount=0;
            int TotalLetterCount=0;

            foreach (var item in partedWords)
            {
                TotalWordCount++;
            }

            foreach (var item in words)
            {
                if(item==' ')
                {
                    continue;
                }
                else
                {
                    TotalLetterCount++;
                }
            }

            Console.WriteLine("Total Word Count: "+TotalWordCount);
            Console.WriteLine("Total Letter Count: "+TotalLetterCount);


            
            



        }
    }
}
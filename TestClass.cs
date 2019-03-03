using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace JapaneseThing
{
    class TestClass
    {
        private static List<String> questions = new List<String>();
        private static List<String> wordsOrExpressions = new List<String>();
        private static List<String> translations = new List<String>();

        public static void beginTest()
        {
            Random random = new Random();

            Console.WriteLine("Please Write your answers on a sheet of paper to practice writing.");
            Console.WriteLine("Press Enter to get the answer. Press enter again to go to the next question.");
            Console.WriteLine("This gives you enough time to compare your answer.\n");

            //Record what question have been asked
            List<int> questionsAsked = new List<int>();
            int index = -1;

            Stopwatch stopwatch = new Stopwatch();
            for (int questionNumber=1; questionNumber < questions.Count+1; questionNumber++)
            {
                Console.WriteLine("Question " + questionNumber + ":");

                do
                {
                    index = random.Next(0, questions.Count);
                } while (questionsAsked.Contains(index));

                questionsAsked.Add(index);

                Console.WriteLine(questions[index]);
                
                Console.WriteLine(wordsOrExpressions[index]);

                stopwatch.Reset();

                stopwatch.Start();

                String answer = Console.ReadLine();

                stopwatch.Stop();

                Console.WriteLine("The right answer is: " + translations[index]+"\n");
                Console.WriteLine("Compare your answer.\n");
                Console.WriteLine("Time to complete: " + (double)stopwatch.ElapsedMilliseconds/1000.0 + " Seconds.\n");

                answer = Console.ReadLine();
            }
        }

        public static void addWordOrExpression(String question, String Text, String value)
        {
            questions.Add(question);
            wordsOrExpressions.Add(Text);
            translations.Add(value);
            /*
            if (!wordsOrExpressions.Contains(Text))
            {
                questions.Add(question);
                wordsOrExpressions.Add(Text);
                translations.Add(value);
            }
            else
            {
                Console.WriteLine(Text + " is already in the list");
            }
            */
        }
    }
}

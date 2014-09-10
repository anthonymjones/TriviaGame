using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //The logic for your trivia game happens here
            List<Trivia> AllQuestions = GetTriviaList();

            int incorrect = 0;
            int correct = 0;
            int questionAsk = 10;
            Console.WriteLine(@"Welcome to C# Trivia!
I'll dish out 10 trivia questions and you type the answer and press enter.
Are you ready? (press enter)");
            Console.ReadKey();

            int number = 1;
            while (questionAsk > 0)
            {
                Random rng = new Random();
                int ranNum = rng.Next(0, 5001);
                var questNum = GetTriviaList()[ranNum];

                Console.WriteLine(questNum.Question);
                var userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == questNum.Answer.ToLower())
                {
                    Console.WriteLine("You got it!");
                    questionAsk--;
                    number++;
                    correct++;
                    Console.WriteLine("The answer is: {0}", questNum.Answer);
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    questionAsk--;
                    number++;
                    incorrect++;
                    Console.WriteLine("The answer is: {0}", questNum.Answer);

                }
                
            }
            Console.WriteLine("You got {0}/10", correct, questionAsk, "right!" );
            Console.WriteLine("You got {0}/10", incorrect, questionAsk, "wrong.");

            Console.ReadKey();
        }


        //This function gets the full list of trivia questions from the Trivia.txt document
        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (var item in contents)
            {
                
            }
            
            //make a new list to return all trivia questions
            List<Trivia> returnList = new List<Trivia>();
            // TODO: go through each line in contents of the trivia file and make a trivia object.
            //       add it to our return list.
            // Example: Trivia newTrivia = new Trivia("what is my name?*question");
            foreach (var question in contents)
            {
                Trivia triviaObject = new Trivia(question);
                returnList.Add(triviaObject);
            }
            //Return the full list of trivia questions
            return returnList;
        }
    }
}

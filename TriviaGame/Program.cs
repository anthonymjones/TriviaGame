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
            //set var for incorrect answers
            int incorrect = 0;
            //set var for correct answers
            int correct = 0;
            //set var for number of questions asked
            int questionaAsked = 0;
            //set var for question number
            int number = 1;
            //welcome to the game
            Console.WriteLine(@"Welcome to C# Trivia!

I'll dish out 10 trivia questions and you type the answer and press enter.

Are you ready? (press enter)");
            Console.ReadKey();

            //loop through until game has asked 10 questions
            while (questionaAsked < 9)
            {
                //create random number generator
                Random rng = new Random();
                //pick random number from 1 - 5000
                int ranNum = rng.Next(0, 5001);
                //set var for the single question/answer in the trivia.txt
                var questNum = GetTriviaList()[ranNum];
                //ask a question
                Console.WriteLine(questNum.Question);
                //get an answer
                var userAnswer = Console.ReadLine().ToLower();
                //got it right
                if (userAnswer == questNum.Answer.ToLower())
                {
                    //tell them
                    Console.WriteLine("You got it!");
                    //add a question asked
                    questionaAsked++;
                    //increase the question number
                    number++;
                    //add a correct answer
                    correct++;
                    //confirm the correct answer
                    Console.WriteLine("It's {0}!", questNum.Answer);
                }
                    //got it wrong
                else
                {
                    //tell them
                    Console.WriteLine("Incorrect!");
                    //add a question asked
                    questionaAsked++;
                    //increase the question number
                    number++;
                    //add an incorrect answer
                    incorrect++;
                    //give them the right answer
                    Console.WriteLine("The answer is: {0}", questNum.Answer);

                }
                
            }
            Console.WriteLine("Game Over.");
            //after the game, display how many correct and incorrect answers
            Console.WriteLine("You got {0}/10", correct, questionaAsked, "right!" );
            Console.WriteLine("You got {0}/10", incorrect, questionaAsked, "wrong.");
            
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

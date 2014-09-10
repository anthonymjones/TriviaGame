using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        //TODO: Fill out the Trivia Object
        
        //The Trivia Object will have 2 properties
        // at a minimum, Question and Answer
        //STEP 1. Declare Properties
        public string Question { get; set; }
        public string Answer { get; set; }
        //The Constructor for the Trivia object will
        // accept only 1 string parameter.  You will
        // split the question from the answer in your
        // constructor and assign them to the Question
        // and Answer properties
        //STEP 2. Constructors
        public Trivia(string question, string answer)
        {
            //set the question
            this.Question = question;
            //set the answer
            this.Answer = answer;
        }
        //STEP 3. Method and/or Functions
        public string AskAQuestion()
        {
            //split the contents at the * and return the 0 index to ask a question
            return this.Question + " " + "?";
        }
        public string GiveAnAnswer()
        {
            //split the contents at the * and return the 1 index to give an answer
            return this.Answer;
        }
    }
}

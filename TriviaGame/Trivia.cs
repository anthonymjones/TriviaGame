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
        public Trivia(string triviaSplit)
        {

            List<string> QuestAndAns = new List<string>();

            QuestAndAns = triviaSplit.Split('*').ToList();
           //set the question
            this.Question = QuestAndAns[0];
            //set the answer
            this.Answer = QuestAndAns[1];
        }
        
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
   class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

       public  int NoOfQuestions;

        public Answers(int i ,int AnswersId , string AnwerText) 
        {
            NoOfQuestions = i;
            this.AnswerId = AnswersId;
            this.AnswerText = AnwerText;
        }

        public override string ToString()
        {
            return $"{NoOfQuestions} ::: {AnswerId} :: {AnswerText}";
        }

    }
}

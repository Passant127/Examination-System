using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     class TFQuestion: QuestionsBase
    {
        public TFQuestion(int i ,string _Header , string _Body , double Mark) : base(i,_Header,_Body,Mark) {
          
        }

        public override string ToString()
        {
            return $"{QuestionNumber} :: {Header} :: {Body} :: {Mark}"; ;
        }


    }
}

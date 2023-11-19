using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class QuestionsBase
    {


        public string Header { get; set; }

        public String Body { get; set; }


        public double Mark { get; set; }
         public int QuestionNumber;
        public QuestionsBase() { }

        public QuestionsBase(int i, string _Header, string _Body, double Mark)
        {
            QuestionNumber = i;
            this.Header = _Header;
            this.Body = _Body;
            this.Mark = Mark;
        }
        public override string ToString()
        {
            return $"{QuestionNumber} :: {Header} :: {Body} :: {Mark}";
        }
    }
}

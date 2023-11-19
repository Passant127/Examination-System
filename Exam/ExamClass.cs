using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class ExamClass
    {
        public int TimeOfExam { get; set; }
        public int NoOfQuestions { get; set; }
        public ExamClass(int _TimeOfExam, int _NoOfQuestions)
        {
            TimeOfExam = _TimeOfExam;
            NoOfQuestions = _NoOfQuestions;
        }
        public abstract void Show();
    }
}

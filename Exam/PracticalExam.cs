using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class PracticalExam : ExamClass
    {

        List<Answers> MCQAnswers = new List<Answers>();
        List<QuestionsBase> Questions = new List<QuestionsBase>();
        MCQ mCQ = new MCQ();
        public PracticalExam(int _TimeOfExam, int _NoOfQuestions) : base(_TimeOfExam, _NoOfQuestions)
        {
            TimeOfExam = _TimeOfExam;
            NoOfQuestions = _NoOfQuestions;
        }

        public void CreatePracticalExam()
        {

            Console.Clear();

            for (int i = 1; i <= NoOfQuestions; i++)
            {
                mCQ.MCQCreate(Questions, MCQAnswers, i);
            }

        }
        public override void Show()
        {
            Console.Clear() ;
            double Grade = 0;
            foreach (var item in Questions)
            {
                Grade += mCQ.MCQShow(item, Questions, MCQAnswers);


            }

            Console.Clear();
           foreach(var item in Questions)
            {
                mCQ.ViewMCQResult(item, MCQAnswers);
            }
            Console.WriteLine($"Your Grade ---> {Grade}");

        }
    }
}

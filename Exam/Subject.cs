using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{

    // Subject Class
    class Subject
    {
        #region Automatic Properties 
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        public ExamClass ExamC;
        #endregion


        #region Constructor
        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectID = _SubjectId;
            SubjectName = _SubjectName;
        }
        #endregion


        #region CreateExam Function
        public void CreateExam()
        {

            int n, Time, NoOfQuestions;
            bool flag;

            do
            {
                Console.Write("Plaese Enter Type Of Exam You Want To Create (1 for Practical and 2 for Final): ");
                flag = int.TryParse(Console.ReadLine(), out n);
            } while (!flag || (n != 1 &&  n != 2));


            do
            {
                Console.Write("Plaese Enter The Exam Time In Minutes: ");

                flag = int.TryParse(Console.ReadLine(), out Time);
            } while (!flag );


            do
            {
                Console.Write("Plaese Enter The Number Of Questions You Wanted To Create: ");
                flag = int.TryParse(Console.ReadLine(), out NoOfQuestions);


            } while (!flag);


            if (n == 1)
            {
                PracticalExam practicalExam = new PracticalExam(Time, NoOfQuestions);
                ExamC = practicalExam;
              
                practicalExam.CreatePracticalExam();
                Console.Clear();

            }
            else 
            {
                FinalExam finalExam = new FinalExam(Time, NoOfQuestions);
                ExamC = finalExam;
                finalExam.CreateFinalExam();
                Console.Clear();

            }
            
        }
        #endregion
    }
}

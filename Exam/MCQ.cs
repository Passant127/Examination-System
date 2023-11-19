using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQ : QuestionsBase
    {
    
        public MCQ()
        {

        }
        public MCQ(int i, string _Header, string _Body, double Mark) : base(i, _Header, _Body, Mark)
        {

        }

        //To Avoid Reapeating Code 
        public void MCQCreate(List<QuestionsBase> Questions, List<Answers> MCQAnswers, int i)
        {
            string Header = "Please Choose One Answer";
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter The Body of Question:");
          
            string Body = Console.ReadLine();
            double Mark ; bool flag;
            do
            {

                Console.WriteLine("Please Enter The Marks of Question: ");

                flag = double.TryParse(Console.ReadLine(), out Mark);
            } while (!flag);
            Console.WriteLine("Please Enter The Marks of Question: ");
            for (int j = 1; j <= 3; j++)
            {

                Console.Write($"Please Enter The Choice Number {j} : ");
                string Ans = Console.ReadLine();
                MCQAnswers.Add(new Answers(i, j, Ans));


            }
          
         

            int RightID;
            do
            {
                Console.WriteLine("Please Specify Right Choice of Question: ");
                flag = int.TryParse(Console.ReadLine(), out RightID);

            } while (!flag || (RightID != 1 && RightID != 2 && RightID != 3));

            string Text = " ";
            foreach (var item in MCQAnswers)
            {
                if (item.AnswerId == RightID)
                {
                    Text = item.AnswerText;
                }

            }
            MCQAnswers.Add(new Answers(i, RightID, Text));

            Questions.Add(new QuestionsBase(i, Header, Body, Mark));

            //Console.Clear();
        }
        public double MCQShow(QuestionsBase item, List<QuestionsBase> Questions, List<Answers> MCQAnswers)
        {
            double Grade = 0;
            int num = -1;
            Console.WriteLine($"{item.Header} \t \t \tMark({item.Mark})");
            Console.WriteLine($"{item.Body}");

          
            for (int i = 0; i < MCQAnswers.Count; i += 4)
            {
                if (MCQAnswers[i].NoOfQuestions == item.QuestionNumber)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{MCQAnswers[i + j].AnswerText} \t \t ");
                    }
                    num += 4;

                    Console.WriteLine();
                    Console.Write("Enter Choice: "); 
                    int idanswer = int.Parse(Console.ReadLine());

                    Console.WriteLine("=================================================");
                    Console.WriteLine();

                 


                    if (idanswer == MCQAnswers[num].AnswerId)
                    {
                        Grade += item.Mark;
                    }
                }

            }
            return Grade;
        }

        public void ViewMCQResult(QuestionsBase item2, List<Answers> MCQAnswers)
        {
            int num = 3;

            
            for (int i = 1; i <= MCQAnswers.Count; i += 4)
            {

                if (MCQAnswers[i].NoOfQuestions == item2.QuestionNumber)
                {

                    Console.WriteLine($"{item2.Body}: {MCQAnswers[num].AnswerText} ");



                }
              
                num += 4;
            }
        }
        public override string ToString()
        {
            return $"{QuestionNumber} :: {Header} :: {Body} :: {Mark}";
        }

    }
}
 
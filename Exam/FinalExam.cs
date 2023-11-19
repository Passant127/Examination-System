using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class FinalExam : ExamClass
    {
        List<Answers> TFAnswers = new List<Answers>();
        List<Answers> MCQAnswers = new List<Answers>();
        List<QuestionsBase> Questions = new List<QuestionsBase>();
        MCQ mCQ = new MCQ();



        public FinalExam(int _TimeOfExam, int _NoOfQuestions) : base(_TimeOfExam, _NoOfQuestions)
        {

        }

        public void CreateFinalExam()
        {
            for (int i = 1; i <= NoOfQuestions; i++)
            {
                bool flag;
                Console.Clear();
                int NoOfType;
                do{
                    Console.Write($"Choose type of Question ({i}):(1 For True or False || 2 For MCQ):  ");
                    flag = int.TryParse(Console.ReadLine() , out NoOfType);

                }while( !flag || (NoOfType != 1 && NoOfType != 2));
                Console.Clear();
                if (NoOfType == 1)
                {

                    string Header = "True | False Question";
                    Console.WriteLine(Header);
                    Console.WriteLine("Please Enter Body of Question:");

                    string Body = Console.ReadLine();
                    double Mark;
                    do
                    {

                        Console.WriteLine("Please Enter The Marks of Question : ");

                        flag = double.TryParse(Console.ReadLine(), out Mark);
                    } while (!flag);



                    int RightID;
                    do
                    {
                        Console.WriteLine("Enter Right Answer 1 for True and 2 For False :");
                        flag = int.TryParse(Console.ReadLine(), out RightID);

                    } while (!flag || (RightID != 1 && RightID != 2));


                    string Text = " ";

                    if (RightID == 1)
                    {
                        Text = "TRUE";
                    }
                    else if (RightID == 2)
                    {
                        Text = "FALSE";
                    }
                    TFAnswers.Add(new Answers(i, RightID, Text));
                    Questions.Add(new QuestionsBase(i, Header, Body, Mark));

                    //Console.Clear();

                }
                else if (NoOfType == 2)
                {

                    mCQ.MCQCreate(Questions, MCQAnswers, i);


                }



            }
            Console.Clear();


        }



        public override void Show()
        {
            Console.Clear();
            double Grade = 0;
            double AllMark = 0;
            foreach (var item in Questions)
            {

                if (item.Header == "True | False Question")
                {

                    Console.WriteLine($"{item.Header} \t \t \tMark({item.Mark})");
                    Console.WriteLine($"{item.Body}");

                    Console.WriteLine("1. TRUE \t \t \t \t 2. FALSE");
                    Console.WriteLine("===============================================");

                    for (int i = 0; i < TFAnswers.Count; i += 1)
                    {
                        if (TFAnswers[i].NoOfQuestions == item.QuestionNumber)
                        {
                     
                            Console.Write("Enter Choice:");
                            int idanswer = int.Parse(Console.ReadLine());
                            AllMark += item.Mark;
                            if (idanswer == TFAnswers[i].AnswerId)
                            {
                                Grade += item.Mark;


                            }
                        }
                    }
                }


                else if (item.Header == "Please Choose One Answer")
                {


                    Grade += mCQ.MCQShow(item, Questions, MCQAnswers);
                    AllMark += item.Mark;


                }


            }
            Console.Clear();




            foreach (var item2 in Questions)
            {
                if (item2.Header == "True | False Question")
                {
                    for (int i = 0; i < TFAnswers.Count; i += 1)
                    {
                        if (TFAnswers[i].NoOfQuestions == item2.QuestionNumber)
                        {

                            Console.WriteLine($"{item2.Body}: {TFAnswers[i].AnswerText} ");


                        }



                    }

                }

                else
                {
                    mCQ.ViewMCQResult(item2, MCQAnswers);
                }
                
                
            }
            Console.WriteLine($"Your Grade is {Grade} out of {AllMark}");
        }
    }
}

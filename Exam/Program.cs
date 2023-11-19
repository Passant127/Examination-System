using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject S1 = new Subject(10, "C#");
            S1.CreateExam();
          
            Console.WriteLine("Do You Want To Start The Exam (y|n) : ");
            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                S1.ExamC.Show();
                Console.WriteLine($"Time Elapsed = {stopwatch.Elapsed}");

            }


        }
    }
}
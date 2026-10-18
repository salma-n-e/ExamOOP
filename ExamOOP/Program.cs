using ExaminationSystem;
using System.Diagnostics;

namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(101, "OOP");
            sub.CreateExam();

            Console.Clear();
            Console.Write("Do You Want To Start The Exam? (y | n): ");
            char choice = char.Parse(Console.ReadLine().ToLower());

            if (choice == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                sub.SubjectExam.ShowExam();

                sw.Stop();
                Console.WriteLine($"Elapsed Time: {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Exam Cancelled. Good Luck!");
            }
        }
    }
}

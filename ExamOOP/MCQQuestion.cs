using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            AnswerList = new Answer[3];
        }
        public MCQQuestion(string header , string body , double mark)
           // :base (header , body , mark)
        {
            AnswerList = new Answer[3];
        }
        public override void AddQuestion()
        {
            Header = "MCQ Question";
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Question Body:");
            Body = Console.ReadLine();
            double mark;
            do
            {
                Console.WriteLine("please enter question mark:");

            } while (!double.TryParse(Console.ReadLine(), out mark) || mark <= 0);
            Mark = mark;
            Console.WriteLine("choices of question:");
            for(int i= 0; i< AnswerList.Length; i++)
            {
                Console.Write($"please enter choice number {i + 1}:");
                string choiceText = Console.ReadLine();
                AnswerList[i] = new Answer(i + 1, choiceText);
            }
            int rightAnswerId;
            do
            {
                Console.WriteLine("please enter right answer id:");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > AnswerList.Length);
            RightAnswer = AnswerList[rightAnswerId - 1];
        }
    }
}

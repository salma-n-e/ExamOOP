using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan time, int numberOfQuestions) 
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("------- Practical Exam -------");
            foreach (var question in QuestionsList.Keys)
            {
                Console.WriteLine(question);
                Console.WriteLine("choices:");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine("----------------------------");
                int userAnswerId;
                do
                {
                    Console.Write("Enter your answer ID: ");
                } while (!int.TryParse(Console.ReadLine(), out userAnswerId) || userAnswerId<1 || userAnswerId> question.AnswerList.Length);
                question.UserAnswer = question.AnswerList[userAnswerId - 1];
            }
            Console.Clear();
            Console.WriteLine("---------practical exam right answers---------");
            foreach (var question in QuestionsList.Keys)
            {
                Console.WriteLine($"Question: {question.Body}");
                Console.WriteLine($"Right Answer: {question.RightAnswer.AnswerId}");
            }
        }
    }
}

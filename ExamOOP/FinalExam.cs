using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan time, int numberOfQuestions) 
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            double totalGrade = 0;
            double studentGrade = 0;
            Console.WriteLine("------- Final Exam -------");
            foreach (var question in QuestionsList.Keys)
            {
                totalGrade += question.Mark;
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
                } while (!int.TryParse(Console.ReadLine(), out userAnswerId) || userAnswerId < 1 || userAnswerId> question.AnswerList.Length);
                question.UserAnswer = question.AnswerList[userAnswerId - 1];
                if (question.UserAnswer.AnswerId == question.RightAnswer.AnswerId)
                {
                    studentGrade += question.Mark;
                }
            }
            Console.Clear();
            Console.WriteLine("------- Final Exam Result -------");
            foreach (var question in QuestionsList.Keys)
            {
                Console.WriteLine($"Question: {question.Body}");
                Console.WriteLine($"Your answer: {question.UserAnswer.AnswerText}");
                Console.WriteLine($"Correct answer: {question.RightAnswer.AnswerText}");
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine($"Your grade: {studentGrade} from {totalGrade}");
        }
    }
}

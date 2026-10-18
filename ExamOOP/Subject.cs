using ExamOOP;
using System;

namespace ExaminationSystem
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            int examType;
            do
            {
                Console.Write("Enter Type Of Exam (1 for Practical, 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            int time;
            do
            {
                Console.Write("Enter Time Of Exam in Minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out time) || time <= 0);

            int numberOfQuestions;
            do
            {
                Console.Write("Enter Number Of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0);

            if (examType == 1)
            {
                SubjectExam = new PracticalExam(TimeSpan.FromMinutes(time), numberOfQuestions);
            }
            else
            {
                SubjectExam = new FinalExam(TimeSpan.FromMinutes(time), numberOfQuestions);
            }

            Console.Clear();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"--- Question {i + 1} ---");
                if (examType == 1) 
                {
                    MCQQuestion mcq = new MCQQuestion();
                    mcq.AddQuestion();
                    SubjectExam.QuestionsList.Add(mcq, mcq.RightAnswer);
                }
                else 
                {
                    int qType;
                    do
                    {
                        Console.Write("Enter Question Type (1 for True/False, 2 for MCQ): ");
                    } while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2));

                    if (qType == 1)
                    {
                        TFQuestion tf = new TFQuestion();
                        tf.AddQuestion();
                        SubjectExam.QuestionsList.Add(tf, tf.RightAnswer);
                    }
                    else
                    {
                        MCQQuestion mcq = new MCQQuestion();
                        mcq.AddQuestion();
                        SubjectExam.QuestionsList.Add(mcq, mcq.RightAnswer);
                    }
                }
            }
        }
    }
}
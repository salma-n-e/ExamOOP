using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ExamOOP
{
    public class TFQuestion : Question
    {
        public TFQuestion() 
        {
            AnswerList = new Answer[2] 
              {
                  new Answer(1, "True"),
                    new Answer(2, "False")
                };
        }
        public TFQuestion(string header, string body, double mark)
          //  : base(header, body, mark)
        {
            AnswerList = new Answer[2]
                {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                };
        }
        public override void AddQuestion()
        {
            Header = "True/False Question";
            Console.WriteLine(Header);
            Console.WriteLine("please Enter Question Body:");
            Body = Console.ReadLine();
            double mark;
            do
            {
                Console.WriteLine("please Enter Question Mark:");
            }
            while (!double.TryParse(Console.ReadLine(), out mark)|| mark<= 0);
            Mark = mark;
            int rightAnswerId;
            do
            {
                Console.WriteLine("please Enter Answer Id (1 for True, 2 for False):");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId != 1 && rightAnswerId != 2));
            RightAnswer = AnswerList[rightAnswerId - 1];
        }
        }
    }



using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public TimeSpan time { get; set; }
        public int numberOfQuestions { get; set; }
        public Dictionary<Question , Answer> QuestionsList { get; set; }
        public Exam(TimeSpan time, int numberOfQuestions)
        {
            this.time = time;
            this.numberOfQuestions = numberOfQuestions;
            this.QuestionsList = new Dictionary<Question, Answer>();
        }
        public abstract void ShowExam();
        
        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.numberOfQuestions.CompareTo(other.numberOfQuestions);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

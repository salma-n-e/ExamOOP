using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer()
        {
            AnswerId = 0;
            AnswerText = string.Empty;
        }
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString()
        {
            return $"AnswerId: {AnswerId}, AnswerText: {AnswerText}";
        }
        public int CompareTo(Answer other)
        {
            if (other == null) return 1;
            return this.AnswerId.CompareTo(other.AnswerId);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

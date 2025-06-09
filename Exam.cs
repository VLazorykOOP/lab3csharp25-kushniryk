using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Exam : Test
    {
        private string examDate;

        public Exam(string subject, int maxScore, string examDate)
            : base(subject, maxScore)
        {
            this.examDate = examDate;
        }

        public override void ConductTest()
        {
            Console.WriteLine($"Conducting exam for {subject} on {examDate}");
        }
    }
}

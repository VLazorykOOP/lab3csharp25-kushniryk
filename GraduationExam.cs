using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class GraduationExam : Test
    {
        private string graduationDate;

        public GraduationExam(string subject, int maxScore, string graduationDate)
            : base(subject, maxScore)
        {
            this.graduationDate = graduationDate;
        }

        public override void ConductTest()
        {
            Console.WriteLine($"Conducting graduation exam for {subject} on {graduationDate}");
        }
    }
}

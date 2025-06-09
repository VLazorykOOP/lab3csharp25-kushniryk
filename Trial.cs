using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Trial : Test
    {
        private string trialType;

        public Trial(string subject, int maxScore, string trialType)
            : base(subject, maxScore)
        {
            this.trialType = trialType;
        }

        public override void ConductTest()
        {
            Console.WriteLine($"Conducting trial for {subject} of type {trialType}");
        }
    }
}

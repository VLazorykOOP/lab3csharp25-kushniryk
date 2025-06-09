using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    abstract class Test
    {
        protected string subject;
        protected int maxScore;

        public Test(string subject, int maxScore)
        {
            this.subject = subject;
            this.maxScore = maxScore;
        }

        public abstract void ConductTest();
    }
}

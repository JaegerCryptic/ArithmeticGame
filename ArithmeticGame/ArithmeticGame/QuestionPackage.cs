using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    class QuestionPackage
    {
        public int QuesionNo1 { get; set; }
        public int QuestionNo2 { get; set; }
        public int QuestionAnswer { get; set; }

        public QuestionPackage(int no1, int no2, int answer)
        {
            QuesionNo1 = no1;
            QuestionNo2 = no2;
            QuestionAnswer = answer;
        }

    }
}

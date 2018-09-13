using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    class QuestionPackage
    {
        public int QuestionNo1 { get; set; }
        public int QuestionNo2 { get; set; }
        public int QuestionAnswer { get; set; }
        public string QuestionOperator { get; set; }

        public QuestionPackage(int no1, string aOperator, int no2, int answer)
        {
            QuestionNo1 = no1;
            QuestionNo2 = no2;
            QuestionAnswer = answer;
            QuestionOperator = aOperator;
        }

        public QuestionPackage(byte[] data)
        {
            QuestionNo1 = BitConverter.ToInt32(data, 0);
            QuestionOperator = BitConverter.ToString(data, 1);
            QuestionNo2 = BitConverter.ToInt32(data, 2);
            QuestionAnswer = BitConverter.ToInt32(data, 3);
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(QuestionNo1));
            byteList.AddRange(BitConverter.GetBytes(QuestionNo2));
            byteList.AddRange(BitConverter.GetBytes(QuestionAnswer));
            return byteList.ToArray();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class QuestionPackage
    {
        public uint QuestionNo1 { get; set; }
        public uint QuestionNo2 { get; set; }
        public uint QuestionAnswer { get; set; }
        public string QuestionOperator { get; set; }

        public QuestionPackage()
        {

        }

        public QuestionPackage(int no1, string aOperator, int no2, int answer)
        {
            QuestionNo1 = Convert.ToUInt32(no1);
            QuestionNo2 = Convert.ToUInt32(no2);
            QuestionAnswer = Convert.ToUInt32(answer);
            QuestionOperator = aOperator;
        }

        public QuestionPackage(byte[] data)
        {
            QuestionNo1 = BitConverter.ToUInt32(data, 0);
            QuestionNo2 = BitConverter.ToUInt32(data, 4);
            QuestionAnswer = BitConverter.ToUInt32(data, 8);
            int operatorLength = BitConverter.ToInt32(data, 12);
            QuestionOperator = Encoding.ASCII.GetString(data, 16, operatorLength);
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(QuestionNo1));
            byteList.AddRange(BitConverter.GetBytes(QuestionNo2));
            byteList.AddRange(BitConverter.GetBytes(QuestionAnswer));
            byteList.AddRange(BitConverter.GetBytes(QuestionOperator.Length));
            byteList.AddRange(Encoding.ASCII.GetBytes(QuestionOperator));

            return byteList.ToArray();
        }

    }
}

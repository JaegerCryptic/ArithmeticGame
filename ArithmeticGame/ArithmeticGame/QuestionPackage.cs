///-------------------------------------------------------------------------------------------------
///	Author: Kyle Kent
/// 
/// Student Number: 465510139
///	
/// Purpose: Arithmetic Game
/// 
/// Version Control: GitHub
///-------------------------------------------------------------------------------------------------

///-------------------------------------------------------------------------------------------------
// file:	QuestionPackage.cs
//
// summary:	Implements the question package class
///-------------------------------------------------------------------------------------------------

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A question package. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------
    class QuestionPackage
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question no 1. </summary>
        ///
        /// <value> The question no 1. </value>
        ///-------------------------------------------------------------------------------------------------

        public uint QuestionNo1 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question no 2. </summary>
        ///
        /// <value> The question no 2. </value>
        ///-------------------------------------------------------------------------------------------------

        public uint QuestionNo2 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question answer. </summary>
        ///
        /// <value> The question answer. </value>
        ///-------------------------------------------------------------------------------------------------

        public uint QuestionAnswer { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question operator. </summary>
        ///
        /// <value> The question operator. </value>
        ///-------------------------------------------------------------------------------------------------

        public string QuestionOperator { get; set; }
        /// <summary>   The value. </summary>
        public int Value { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public QuestionPackage()
        {

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="no1">          The first no. </param>
        /// <param name="aOperator">    The operator. </param>
        /// <param name="no2">          The second no. </param>
        /// <param name="answer">       The answer. </param>
        ///-------------------------------------------------------------------------------------------------
        public QuestionPackage(int no1, string aOperator, int no2, int answer, int value)
        {
            QuestionNo1 = Convert.ToUInt32(no1);
            QuestionNo2 = Convert.ToUInt32(no2);
            QuestionAnswer = Convert.ToUInt32(answer);
            QuestionOperator = aOperator;
            Value = value;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="data"> The data. </param>
        ///-------------------------------------------------------------------------------------------------

        public QuestionPackage(byte[] data)
        {
            QuestionNo1 = BitConverter.ToUInt32(data, 0);
            QuestionNo2 = BitConverter.ToUInt32(data, 4);
            QuestionAnswer = BitConverter.ToUInt32(data, 8);
            int operatorLength = BitConverter.ToInt32(data, 12);
            QuestionOperator = Encoding.ASCII.GetString(data, 16, operatorLength);
            Value = BitConverter.ToInt16(data, 20);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts this object to a byte array. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   This object as a byte[]. </returns>
        ///-------------------------------------------------------------------------------------------------

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(QuestionNo1));
            byteList.AddRange(BitConverter.GetBytes(QuestionNo2));
            byteList.AddRange(BitConverter.GetBytes(QuestionAnswer));
            byteList.AddRange(BitConverter.GetBytes(QuestionOperator.Length));
            byteList.AddRange(Encoding.ASCII.GetBytes(QuestionOperator));
            byteList.AddRange(BitConverter.GetBytes(Value));

            return byteList.ToArray();
        }
    }
}

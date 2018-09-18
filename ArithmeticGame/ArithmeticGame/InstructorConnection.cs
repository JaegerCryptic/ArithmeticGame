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
// file:	InstructorConnection.cs
//
// summary:	Implements the instructor connection class
///-------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An instructor connection. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------
    class InstructorConnection
    {
        /// <summary>   The client socket. </summary>
        private Socket clientSocket;
        /// <summary>   The buffer. </summary>
        private byte[] buffer;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor question 1. </summary>
        ///
        /// <value> The instructor question 1. </value>
        ///-------------------------------------------------------------------------------------------------

        int instructorQuestion1 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor question 2. </summary>
        ///
        /// <value> The instructor question 2. </value>
        ///-------------------------------------------------------------------------------------------------

        int instructorQuestion2 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor answer. </summary>
        ///
        /// <value> The instructor answer. </value>
        ///-------------------------------------------------------------------------------------------------

        int instructorAnswer { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor operator. </summary>
        ///
        /// <value> The instructor operator. </value>
        ///-------------------------------------------------------------------------------------------------

        string instructorOperator { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question. </summary>
        ///
        /// <value> The question. </value>
        ///-------------------------------------------------------------------------------------------------

        string question { get; set; }
        /// <summary>   True to toggle check. </summary>
        bool toggleCheck = true;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the received instructor first number. </summary>
        ///
        /// <value> The received instructor first number. </value>
        ///-------------------------------------------------------------------------------------------------

        public int receivedInstructorFirstNumber { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the received instructor second number. </summary>
        ///
        /// <value> The received instructor second number. </value>
        ///-------------------------------------------------------------------------------------------------

        public int receivedInstructorSecondNumber { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the received instructor answer. </summary>
        ///
        /// <value> The received instructor answer. </value>
        ///-------------------------------------------------------------------------------------------------

        public int receivedInstructorAnswer { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the receiveda operator. </summary>
        ///
        /// <value> The receiveda operator. </value>
        ///-------------------------------------------------------------------------------------------------

        public string receivedaOperator { get; set; }
        /// <summary>   The value. </summary>
        public int Value { get; set; }

        /// <summary>   The package. </summary>
        QuestionPackage Package = new QuestionPackage();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public InstructorConnection()
        {
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="question1">    The first question. </param>
        /// <param name="theOperator">  the operator. </param>
        /// <param name="question2">    The second question. </param>
        /// <param name="answer">       The answer. </param>
        ///-------------------------------------------------------------------------------------------------

        public InstructorConnection(int question1, string theOperator, int question2, int answer)
        {
            instructorQuestion1 = question1;
            instructorQuestion2 = question2;
            instructorAnswer = answer;
            instructorOperator = theOperator;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Shows the error dialog. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="message">  The message. </param>
        ///-------------------------------------------------------------------------------------------------

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Async callback, called on completion of receive callback. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="AR">   The result of the asynchronous operation. </param>
        ///-------------------------------------------------------------------------------------------------

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                // The received data is deserialized in the PersonPackage ctor.
                Package = new QuestionPackage(buffer);
                Package.Value = 1;
                MessageBox.Show(Package.Value.ToString());
                GetPackage(Package);

                // Start receiving data again.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            // Avoid catching all exceptions handling in cases like these.
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Async callback, called on completion of connect callback. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="AR">   The result of the asynchronous operation. </param>
        ///-------------------------------------------------------------------------------------------------

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
               // ToggleControlState(true);
                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Async callback, called on completion of send callback. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="AR">   The result of the asynchronous operation. </param>
        ///-------------------------------------------------------------------------------------------------

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Receive question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="question1">    The first question. </param>
        /// <param name="question2">    The second question. </param>
        /// <param name="answer">       The answer. </param>
        ///-------------------------------------------------------------------------------------------------

        private void ReceiveQuestion(int question1, int question2, int answer)
        {
            instructorQuestion1 = question1;
            instructorQuestion2 = question2;
            instructorAnswer = answer;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sends the question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        private void SendQuestion()
        {
            try
            {
                // Serialize the values before sending.
                QuestionPackage package = new QuestionPackage(instructorQuestion1, instructorOperator, instructorQuestion2, instructorAnswer, Value);
                byte[] buffer = package.ToByteArray();
                clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
                //ToggleControlState(false);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
                ToggleControlState(false);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
                ToggleControlState(false);
            }
        }
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Connects the question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public void ConnectQuestion()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Connect to the specified host.
                var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333);
                clientSocket.BeginConnect(endPoint, ConnectCallback, null);
                SendQuestion();
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Toggle control state. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="toggle">   True to toggle. </param>
        ///-------------------------------------------------------------------------------------------------

        private void ToggleControlState(bool toggle)
        {
            toggleCheck = toggle;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Updates the control state described by btn. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="btn">  The button control. </param>
        ///-------------------------------------------------------------------------------------------------

        public void UpdateControlState(Button btn)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    btn.Enabled = toggleCheck;

                    await Task.Delay(100);
                }
            });
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a package. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="package">  The package. </param>
        ///-------------------------------------------------------------------------------------------------

        private void GetPackage(QuestionPackage package)
        {
            receivedInstructorFirstNumber = Convert.ToInt32(package.QuestionNo1);
            receivedaOperator = package.QuestionOperator.ToString();
            receivedInstructorSecondNumber = Convert.ToInt32(package.QuestionNo2);
            receivedInstructorAnswer = Convert.ToInt32(package.QuestionAnswer);
            question = package.QuestionNo1.ToString() + " " + package.QuestionOperator.ToString() + " "
               + package.QuestionNo2.ToString() + " " + "=";
            Value = package.Value;

            if (receivedaOperator != null)
            {
                //ToggleControlState(true);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Returns the given list. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="list"> The list to return. </param>
        ///-------------------------------------------------------------------------------------------------

        public void Return(NodeList list)
        {
           list.NodeListAddatFront(new Node(instructorAnswer));
        }

    }
}

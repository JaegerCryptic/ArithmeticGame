using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class StudentConnection
    {
        public string question { get; set; }
        int instructorQuestion1 { get; set; }
        int instructorQuestion2 { get; set; }
        public int instructorAnswer { get; set; }
        string instructorOperator { get; set; }
        private bool toggleCheck = false;
        public short Value; 

        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;
        public QuestionPackage Package = new QuestionPackage();

        public StudentConnection()
        {
            StartServer();

        }

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, 3333)); // bind on port  3333
                serverSocket.Listen(10); // listening on a backlog of ten pending connections
                serverSocket.BeginAccept(AcceptCallback, null); // start accepting incoming 
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

        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket = serverSocket.EndAccept(AR); // set up the clientsocket
                buffer = new byte[clientSocket.ReceiveBufferSize]; // intialise the buffer to proper buffer size

                // Send a message to the newly connected client.
                var sendData = Encoding.ASCII.GetBytes("Hello");
                clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallback, null);
                // Listen for client data.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
                // Continue listening for clients.
                serverSocket.BeginAccept(AcceptCallback, null);
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

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                // Socket exception will raise here when client closes, as this sample does not
                // demonstrate graceful disconnects for the sake of simplicity.
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                // The received data is deserialized in the PersonPackage ctor.
                Package = new QuestionPackage(buffer);
                GetPackage(Package);
                ToggleControlState(true);

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

        private void GetPackage(QuestionPackage package)
        {
            question = package.QuestionNo1.ToString() + " " + package.QuestionOperator.ToString() + " "
                + package.QuestionNo2.ToString() + " " + "=";

            instructorQuestion1 = Convert.ToInt32(package.QuestionNo1);
            instructorOperator = package.QuestionOperator.ToString();
            instructorQuestion2 = Convert.ToInt32(package.QuestionNo2);
            instructorAnswer = Convert.ToInt32(package.QuestionAnswer);
            Value = Convert.ToInt16(package.Value);
            MessageBox.Show(Value.ToString());

        }

        public void GetValue(short value)
        {
            Value = value;
        }

        public void SetPackageAsync(TextBox txt)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    txt.Text = question;
                    await Task.Delay(100);
                }
            });
        }

        public void SendQuestion()
        {
            try
            {
                // Serialize the textBoxes text before sending.
                QuestionPackage package = new QuestionPackage(instructorQuestion1, instructorOperator, instructorQuestion2, instructorAnswer, Value);
                byte[] buffer = package.ToByteArray();
                clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
                ToggleControlState(false);
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

        private void ToggleControlState(bool toggle)
        {
            toggleCheck = toggle;
        }

        public void UpdateControlState(Button btn)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    btn.Enabled = toggleCheck;

                    await Task.Delay(200);
                }
            });
        }

    }
}

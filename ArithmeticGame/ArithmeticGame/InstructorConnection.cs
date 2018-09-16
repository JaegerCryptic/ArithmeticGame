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
    class InstructorConnection : InstructorForm
    {
        private Socket clientSocket;
        private Socket receivingSocket;
        private byte[] buffer;
        private Socket serverSocket;
        int instructorQuestion1 { get; set; }
        int instructorQuestion2 { get; set; }
        int instructorAnswer { get; set; }
        string instructorOperator { get; set; }
        bool toggleCheck = true;
        QuestionPackage Package = new QuestionPackage();

        public InstructorConnection(int question1, string theOperator, int question2, int answer)
        {
            instructorQuestion1 = question1;
            instructorQuestion2 = question2;
            instructorAnswer = answer;
            instructorOperator = theOperator;
        }

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void StartServer()
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
                receivingSocket = serverSocket.EndAccept(AR); // set up the clientsocket
                buffer = new byte[receivingSocket.ReceiveBufferSize]; // intialise the buffer to proper buffer size

                // Send a message to the newly connected client.
                var sendData = Encoding.ASCII.GetBytes("Hello");
                receivingSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendReceivingCallback, null);
                // Listen for client data.
                receivingSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivingCallback, null);
                // Continue listening for clients.
                serverSocket.BeginAccept(AcceptCallback, null);
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

        private void ReceivingCallback(IAsyncResult AR)
        {
            try
            {
                // Socket exception will raise here when client closes, as this sample does not
                // demonstrate graceful disconnects for the sake of simplicity.
                int received = receivingSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                // The received data is deserialized in the PersonPackage ctor.
                Package = new QuestionPackage(buffer);
                //GetPackage(Package);


                // Start receiving data again.
                receivingSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivingCallback, null);
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

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }


                string message = Encoding.ASCII.GetString(buffer);

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

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
                ToggleControlState(true);
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

        private void SendReceivingCallback(IAsyncResult AR)
        {
            try
            {
                receivingSocket.EndSend(AR);
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

        private void ReceiveQuestion(int question1, int question2, int answer)
        {
            instructorQuestion1 = question1;
            instructorQuestion2 = question2;
            instructorAnswer = answer;
        }

        private void SendQuestion()
        {
            try
            {
                // Serialize the textBoxes text before sending.
                QuestionPackage package = new QuestionPackage(instructorQuestion1, instructorOperator, instructorQuestion2, instructorAnswer);
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

                    await Task.Delay(100);
                }
            });
           
        }
    }
}

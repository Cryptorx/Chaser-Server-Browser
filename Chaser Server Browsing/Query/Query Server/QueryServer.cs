using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Chaser_Server_Browsing.Query.Query_Server
{
    class QueryServer
    {
        public string QueryS(string ip, int port)
        {
            UdpClient udpClient = new UdpClient(12000);
            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);
            try
            {
                udpClient.Connect(ip, Convert.ToInt32(port));

                Byte[] sendBytes = Encoding.ASCII.GetBytes("\\status\\");

                udpClient.Send(sendBytes, sendBytes.Length);
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                udpClient.Close();
                udpClient.Dispose();
                return returnData;
            }
            catch (Exception)
            {
                udpClient.Close();
                udpClient.Dispose();
                return null;
            }
        }
    }
}

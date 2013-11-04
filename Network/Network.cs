using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Network {
    public class Network{
        public static Dictionary<byte, String> Peers = new Dictionary<byte, String>();
        public static byte[] ReceiveData(Socket socket){ //receives and trims raw data
            byte[] buffer = new byte[256];
            int receivedLength = socket.Receive(buffer);
            byte[] trimmedBuffer = new byte[receivedLength];
            Array.Copy(buffer, trimmedBuffer, receivedLength);
            return trimmedBuffer;
        }
        public static void Disconnect(Socket socket, byte ID){
            
        }
        public static void SendData(Socket socket, byte[] data, byte ID){
            
        }
        public static void SendByte(Socket socket, byte data, byte ID){
   
        }
    }
}

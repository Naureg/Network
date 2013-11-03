using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Network {
    abstract class Network{
        public Dictionary<byte, String> Peers = new Dictionary<byte, String>();
        public abstract byte[] ReceiveData(Socket socket);
        public abstract void Disconnect(Socket socket);
    }
}

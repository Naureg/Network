using System;

namespace Network {
    public class Peer{
        private String alias;
        private byte ID;
        public Peer(String alias, byte ID){
            this.alias = alias;
            this.ID = ID;
        }
    }
}

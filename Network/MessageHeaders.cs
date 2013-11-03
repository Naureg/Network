namespace Network{
    /*
     * Message headers are prepended to the outgoing bytes
     * in order for the server/client to determine the contents
     * or purpose of the incoming data
     */
    public enum MessageHeaders : byte{
        MESSAGE = 0x0,
        SET_ALIAS = 0x1,
        REQUEST_PEERS = 0x2,
        RECEIVED_PEERS = 0x3,
        RECEIVED_PEER = 0x4,
        TIMESTAMP = 0x5,
        DISCONNECT = 0x6,
    }
}

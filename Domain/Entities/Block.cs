using System;

namespace BlockchainApp.Domain.Entities
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime Timestamp { get; set; }
        public string Data { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public int Nonce { get; set; }

        public Block(int index, string data, string previousHash = "")
        {
            Index = index;
            Timestamp = DateTime.UtcNow;
            Data = data;
            PreviousHash = previousHash;
            Nonce = 0;
            Hash = string.Empty;
        }
    }
}


using System.Collections.Generic;

namespace BlockchainApp.Domain.Entities
{
    public class Blockchain
    {
        public List<Block> Chain { get; private set; }

        public Blockchain()
        {
            Chain = new List<Block>();
        }

        public Block GetLatestBlock()
        {
            return Chain.Count == 0 ? null : Chain[^1];
        }

        public void AddBlock(Block block)
        {
            Chain.Add(block);
        }
    }
}


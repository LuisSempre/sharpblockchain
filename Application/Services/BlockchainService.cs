using BlockchainApp.Domain.Entities;
using BlockchainApp.Domain.Interfaces;
using BlockchainApp.Shared.Utilities;

namespace BlockchainApp.Application.Services
{
    public class BlockchainService : IBlockchainService
    {
        private readonly Blockchain _blockchain;
        private readonly int _difficulty = 2;

        public BlockchainService()
        {
            _blockchain = new Blockchain();
            CreateGenesisBlock();
        }

        public void CreateGenesisBlock()
        {
            var genesis = new Block(0, "Genesis Block", "0");
            MineBlock(genesis);
            _blockchain.AddBlock(genesis);
        }

        public void AddBlock(string data)
        {
            var latest = _blockchain.GetLatestBlock();
            var newBlock = new Block(_blockchain.Chain.Count, data, latest?.Hash ?? "0");
            MineBlock(newBlock);
            _blockchain.AddBlock(newBlock);
        }

        private void MineBlock(Block block)
        {
            string target = new string('0', _difficulty);
            do
            {
                block.Nonce++;
                block.Hash = HashUtility.CalculateHash(block);
            } while (!block.Hash.StartsWith(target));
        }

        public bool IsChainValid()
        {
            for (int i = 1; i < _blockchain.Chain.Count; i++)
            {
                var current = _blockchain.Chain[i];
                var previous = _blockchain.Chain[i - 1];

                if (current.Hash != HashUtility.CalculateHash(current)) return false;
                if (current.PreviousHash != previous.Hash) return false;
            }
            return true;
        }

        public Blockchain GetBlockchain() => _blockchain;
    }
}


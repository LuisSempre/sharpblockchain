using BlockchainApp.Domain.Entities;

namespace BlockchainApp.Domain.Interfaces
{
    public interface IBlockchainService
    {
        void CreateGenesisBlock();
        void AddBlock(string data);
        bool IsChainValid();
        Blockchain GetBlockchain();
    }
}


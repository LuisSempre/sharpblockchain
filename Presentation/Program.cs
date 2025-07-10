using BlockchainApp.Application.Services;
using BlockchainApp.Domain.Entities;

class Program
{
    static void Main(string[] args)
    {
        var blockchainService = new BlockchainService();

        Console.WriteLine("Adicionando bloco 1...");
        blockchainService.AddBlock("Transação 1: 50 moedas");

        Console.WriteLine("Adicionando bloco 2...");
        blockchainService.AddBlock("Transação 2: 25 moedas");

        Console.WriteLine("\nValidação da blockchain:");
        Console.WriteLine(blockchainService.IsChainValid() ? "Blockchain válida ✅" : "Blockchain inválida ❌");

        Console.WriteLine("\n--- Blockchain ---");
        foreach (var block in blockchainService.GetBlockchain().Chain)
        {
            Console.WriteLine($"Index: {block.Index}, Hash: {block.Hash}");
        }
    }
}

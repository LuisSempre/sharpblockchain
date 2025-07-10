using BlockchainApp.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainApp.Shared.Utilities
{
    public static class HashUtility
    {
        public static string CalculateHash(Block block)
        {
            string rawData = $"{block.Index}{block.Timestamp}{block.Data}{block.PreviousHash}{block.Nonce}";
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}


# ⚙️ SharpBlockchain

**SharpBlockchain** é uma aplicação educacional e modular de blockchain desenvolvida em **C# com .NET**, seguindo os princípios de **DDD (Domain-Driven Design)** e **Clean Architecture**.

A aplicação demonstra como construir uma blockchain simples e extensível com foco em separação de responsabilidades, testabilidade e boas práticas de arquitetura.

---

## 🧱 Estrutura do Projeto

```plaintext
BlockchainApp/
│
├── Domain/
│   ├── Entities/
│   │   ├── Block.cs               # Representa um bloco da blockchain
│   │   └── Blockchain.cs          # Representa a cadeia de blocos
│   └── Interfaces/
│       └── IBlockchainService.cs  # Contrato da lógica de negócio
│
├── Application/
│   └── Services/
│       └── BlockchainService.cs   # Implementação da lógica de negócio
│
├── Infrastructure/
│   └── Logging/
│       └── ConsoleLogger.cs       # Logger básico para saída de console
│
├── Presentation/
│   └── Program.cs                 # Entrada principal do aplicativo
│
├── Shared/
│   └── Utilities/
│       └── HashUtility.cs         # Utilitário de geração de hash (SHA256)

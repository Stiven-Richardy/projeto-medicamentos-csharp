# 💊 Projeto Medicamento (Console)

Este projeto foi desenvolvido como atividade acadêmica para aplicar conceitos de Estrutura de Dados, especificamente o uso de `Queue<T>` (Fila) e `List<T>`, em uma aplicação C# Console. O sistema simula o gerenciamento de estoque de medicamentos, controlando seus lotes por data de entrada (FIFO - First-In, First-Out).

## 🎯 Objetivos

- Implementar um sistema de **CRUD (Criar, Ler, Remover)** para Medicamentos.
- Gerenciar os lotes de cada medicamento utilizando uma **Fila (`Queue<Lote>`)**, garantindo que o primeiro lote a entrar seja o primeiro a sair.
- Implementar a lógica de **compra** (adicionar um novo lote ao final da fila).
- Implementar a lógica de **venda**, que retira a quantidade dos lotes mais antigos primeiro, removendo-os da fila quando zerados.
- Desenvolver duas formas de consulta: **sintética** (dados do medicamento) e **analítica** (dados do medicamento + seus lotes).
- Permitir a remoção de um medicamento apenas se seu estoque disponível for zero.

## 🛠️ Ferramentas Utilizadas

- C#
- Visual Studio 2022
- Git e GitHub

## 🗂️ Estrutura do Projeto

```
📁 projeto-medicamentos-csharp/
├── 📁 projeto-medicamentos/
│   ├── 📁 projeto-medicamentos/
│   │   ├── 📄 Program.cs
│   │   ├── 📄 Lote.cs
│   │   ├── 📄 Medicamento.cs
│   │   ├── 📄 Medicamentos.cs
│   │   └── 📄 Utils.cs
│   └── 📄 projeto-medicamento.sln
├── 📄 .gitignore
└── 📄 README.md
```

## 🚀 Como Executar

1. Abra a IDE **Visual Studio 2022**.
2. Vá em **Clonar um Repositório** e digite o link `https://github.com/Stiven-Richardy/projeto-medicamentos-csharp`.
3. Selecione a pasta desejada e clone o projeto.
4. Execute a aplicação a partir do Visual Studio.

## 👨‍🏫 Autores

- **Stiven Richardy Silva Rodrigues**  
  Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão  
  [@Stiven-Richardy](https://github.com/Stiven-Richardy)

- **Guilherme Mendes de Sousa**  
  Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão  
  [@Guilh3rme-M3ndes](https://github.com/Guilh3rme-M3ndes)

## 📚 Referências

- C# Reference: [Microsoft C#](https://learn.microsoft.com/pt-br/visualstudio/get-started/csharp/?view=vs-2022)

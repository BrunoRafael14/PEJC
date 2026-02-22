# PEJC - Programa de Estatísticas de Jogos Competitivos

Um programa de console em C# para registrar e analisar partidas de jogos competitivos, gerando estatísticas detalhadas de desempenho por campeão e por lane.

## 🎮 Sobre o Projeto

O PEJC permite que jogadores registrem seus dados de partidas e acompanhem sua evolução ao longo do tempo. Os dados são salvos localmente em arquivos **JSON**. O projeto atualmente foca em **League of Legends**, mas foi arquitetado para suportar outros jogos no futuro.

> 🚧 Projeto em desenvolvimento inicial — novas funcionalidades sendo adicionadas progressivamente.

## 🗂️ Estrutura do Projeto

```
PEJC/
├── Core/
│   ├── IMenu.cs    # Métodos reutilizáveis de navegação de menu
│   └── Validations.cs    # Validações de entrada do usuário
├── Games/
│   └── LeagueOfLegends/
│       ├── Classes/
│       │   ├── Champion.cs   # Modelo de campeão (nome, maestria)
│       │   ├── Match.cs      # Modelo de partida (KDA, PDL, lane, campeão)
│       │   └── Season.cs     # Modelo de temporada
│       ├── Functions/
│       │   └── RecordsAndChanges.cs  # Registro e alterações de dados do LoL
│       └── LolMenu/
│           └── LolMenu.cs    # Menu do League of Legends
├── HomeMenu/
│   └── HomeMenu.cs       # Menu principal e seleção de jogo
├── Program.cs
└── PEJC.csproj
```

## ✅ Funcionalidades Planejadas

### Cadastro
- Cadastrar partida (KDA, PDL ganho, maestria ganha, lane, campeão)
- Cadastrar/editar maestria inicial do campeão

### Visualização por Campeão
- KDA médio
- Vitórias e Derrotas
- Jogos Totais
- Porcentagem de Utilização

### Visualização por Lane
- KDA médio
- Vitórias e Derrotas
- Jogos Totais
- Porcentagem de Utilização

### Partidas
- Listar todas as partidas registradas
- Consultar uma partida específica
- Média de Maestria Ganha
- Média de Nota nas Partidas

### 🏆 Ranking
- Top 3 campeões mais utilizados
- Top 3 campeões com melhor KDA
- Top 3 campeões com mais vitórias/derrotas
- Top 3 lanes mais utilizadas
- Top 3 lanes com melhor KDA
- Top 3 lanes com mais vitórias/derrotas

## 🚀 Como Executar

**Pré-requisito:** [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# Clone o repositório
git clone https://github.com/BrunoRafael14/PEJC.git

# Acesse a pasta do projeto
cd PEJC

# Execute o projeto
dotnet run
```

## 🛠️ Tecnologias

- **Linguagem:** C#
- **Plataforma:** .NET
- **Interface:** Console (terminal)
- **Armazenamento:** JSON (arquivos locais)

## 👨‍💻 Autor

**Bruno Rafael** — [GitHub](https://github.com/BrunoRafael14)
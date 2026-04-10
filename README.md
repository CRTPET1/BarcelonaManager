# 🔵🔴 Barcelona Manager

A Windows Forms football management simulation written in C# (.NET Framework 4.7.2). Manage FC Barcelona's squad across multiple seasons — buy and sell players, simulate season results, track careers, and watch your budget grow or shrink.

---

## Features

- **Squad management** — add players manually (Forward, Midfielder, Defender, Goalkeeper) or buy them from a transfer market of 80+ real-world players
- **Season simulation** — generate goals and assists for each player based on their position and value, with built-in randomness for realistic variance
- **Aging & retirement** — every season players age by 1 year; those over 33 lose 20% of their value, and players who reach 41 or drop below €15M are automatically retired
- **Transfer market** — buy and sell players with a live budget tracker; sold players return to the market
- **Career statistics** — track career goals, assists, and seasons at the club per player
- **Team stats** — view total squad value, average age, MVP, and position distribution

---

## Screenshots

> *Add screenshots here after cloning and running the project.*

---

## Requirements

| Tool | Version |
|------|---------|
| Windows | 10 / 11 |
| Visual Studio | 2022 or newer |
| .NET Framework | 4.7.2 or newer |

---

## Getting Started

**1. Clone the repository**
```bash
git clone https://github.com/YOUR_USERNAME/BarcelonaManager.git
```

**2. Open in Visual Studio**
- Open Visual Studio 2022
- Click **Open a project or solution**
- Navigate to the cloned folder and open `BarcelonaManager.sln`

**3. Run the project**
- Press **F5** or click the **Start** button in the toolbar
- The app will build and launch in a new window

---

## Project Structure

```
BarcelonaManager/
├── Models/
│   ├── Entity.cs               # Base class with auto-generated ID
│   ├── PlayerBase.cs           # Abstract base for all player types
│   ├── Player.cs               # Generic player
│   ├── Forward.cs              # Striker — high goal rate
│   ├── Midfielder.cs           # Midfielder — goals + assists
│   ├── Defender.cs             # Defender — low goal rate
│   ├── Goalkeeper.cs           # Goalkeeper — rare goal logic
│   ├── Team.cs                 # Squad container with stats
│   └── ITransferable.cs        # Interface for transfer eligibility
├── Services/
│   ├── GoalGenerator.cs        # Season simulation with delegate + event
│   ├── TransferMarket.cs       # Buy/sell logic
│   └── MarketPlayerDatabase.cs # Static database of 80+ players
├── Form1.cs                    # Main window
├── AddPlayerForm.cs            # Add player dialog
├── TransferForm.cs             # Transfer market window
├── StatsForm.cs                # Team statistics window
└── PlayerStatsForm.cs          # Individual player career window
```

---

## OOP Concepts Implemented

This project was built as a school assignment to demonstrate core C# and OOP concepts:

| Concept | Where |
|---|---|
| Encapsulation | `PlayerBase`, `AddPlayerForm` (`private set`), `Form1` |
| Constructors | All model classes; static constructor in `MarketPlayerDatabase` |
| Properties | `PlayerBase`, `Team`, `AddPlayerForm` |
| Static & instance methods | `TransferMarket`, `GoalGenerator.GenerateForTeam()` vs `GenerateGoals()` |
| `static` / `const` / `readonly` | `Team.Budget`, `GoalGenerator` goal factors, `MarketPlayerDatabase._allMarketPlayers` |
| Inheritance | `PlayerBase → Forward / Midfielder / Defender / Goalkeeper` |
| Polymorphism | `GoalGenerator` type-checks player at runtime; overridden `ToString()` per class |
| Abstract class | `PlayerBase` with abstract `CalculateSalary()` |
| Interface | `ITransferable` — implemented by all four player subclasses |
| Indexers | `Team[int]`, `MarketPlayerDatabase[int]` |
| Delegates | `GoalsGeneratedHandler` in `GoalGenerator` |
| Events | `OnGoalsGenerated` fires after each player's goals are calculated |
| Custom namespaces | `BarcelonaManager.Models`, `BarcelonaManager.Services` |

---

## Author

**Ožbej Žurman** — R3B  
Srednja šola za kemijo, elektrotehniko in računalništvo  
April 2026

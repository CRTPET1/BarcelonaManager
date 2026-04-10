# 🔵🔴 Barcelona Manager

Namizna aplikacija za upravljanje nogometnega kluba, napisana v C# (.NET Framework 4.7.2) z uporabo Windows Forms. Upravljaj kadro FC Barcelone skozi več sezon — kupuj in prodajaj igralce, simuliraj sezone, spremljaj karierne statistike in pazi na budget.

---

## Funkcionalnosti

- **Upravljanje kadra** — dodajaj igralce ročno (napadalec, vezist, branilec, vratar) ali jih kupuj s prestopnega trga z več kot 80 resničnimi nogometaši
- **Simulacija sezone** — generiranje golov in asistenc za vsakega igralca glede na pozicijo in vrednost, z naključnostjo za realistično varianco
- **Staranje in upokojevanje** — vsako sezono se vsak igralec postara za 1 leto; tisti nad 33 let izgubijo 20 % vrednosti, tisti pri 41 letih ali pod 15 M € pa se samodejno upokojijo
- **Prestopni trg** — kupuj in prodajaj igralce s sledilcem budgeta v živo; prodani igralci se vrnejo na trg
- **Karierne statistike** — beleženje kariernih golov, asistenc in sezon v klubu za vsakega igralca
- **Statistike ekipe** — skupna vrednost kadra, povprečna starost, najdražji igralec in porazdelitev po pozicijah

---

## Zahteve

| Orodje | Različica |
|--------|-----------|
| Windows | 10 / 11 |
| Visual Studio | 2022 ali novejši |
| .NET Framework | 4.7.2 ali novejši |

---

## Zagon projekta

**1. Kloniraj repozitorij**
```bash
git clone https://github.com/YOUR_USERNAME/BarcelonaManager.git
```

**2. Odpri v Visual Studiu**
- Zaženi Visual Studio 2022
- Klikni **Open a project or solution**
- Poišči klonirano mapo in odpri `BarcelonaManager.sln`

**3. Zaženi projekt**
- Pritisni **F5** ali klikni gumb **Start** v orodni vrstici
- Aplikacija se bo prevedla in odprla v novem oknu

---

## Struktura projekta

```
BarcelonaManager/
├── Models/
│   ├── Entity.cs               # Bazni razred z naključno generiranim ID-jem
│   ├── PlayerBase.cs           # Abstraktni bazni razred za vse tipe igralcev
│   ├── Player.cs               # Generičen igralec
│   ├── Forward.cs              # Napadalec — visoko število golov
│   ├── Midfielder.cs           # Vezist — goli + asistence
│   ├── Defender.cs             # Branilec — redki goli
│   ├── Goalkeeper.cs           # Vratar — posebna logika golov
│   ├── Team.cs                 # Vsebnik kadra s statistikami
│   └── ITransferable.cs        # Vmesnik za upravičenost do prestopa
├── Services/
│   ├── GoalGenerator.cs        # Simulacija sezone z delegatom in dogodkom
│   ├── TransferMarket.cs       # Logika nakupa in prodaje
│   └── MarketPlayerDatabase.cs # Statična baza 80+ igralcev
├── Form1.cs                    # Glavno okno
├── AddPlayerForm.cs            # Dialog za dodajanje igralca
├── TransferForm.cs             # Okno prestopnega trga
├── StatsForm.cs                # Okno statistik ekipe
└── PlayerStatsForm.cs          # Okno karierne statistike posameznega igralca
```

---

## Implementirani koncepti OOP

| Koncept | Lokacija |
|---------|----------|
| Kapsulacija | `PlayerBase`, `AddPlayerForm` (`private set`), `Form1` |
| Konstruktorji | Vsi modelni razredi; statični konstruktor v `MarketPlayerDatabase` |
| Lastnosti | `PlayerBase`, `Team`, `AddPlayerForm` |
| Statične in objektne metode | `TransferMarket`, `GoalGenerator.GenerateForTeam()` vs `GenerateGoals()` |
| `static` / `const` / `readonly` | `Team.Budget`, faktorji golov v `GoalGenerator`, `MarketPlayerDatabase._allMarketPlayers` |
| Dedovanje | `PlayerBase → Forward / Midfielder / Defender / Goalkeeper` |
| Polimorfizem | `GoalGenerator` preverja tip igralca med izvajanjem; prepisana `ToString()` v vsakem razredu |
| Abstraktni razred | `PlayerBase` z abstraktno metodo `CalculateSalary()` |
| Vmesnik | `ITransferable` — implementiran v vseh štirih podrazredih |
| Indekserji | `Team[int]`, `MarketPlayerDatabase[int]` |
| Delegati | `GoalsGeneratedHandler` v `GoalGenerator` |
| Dogodki | `OnGoalsGenerated` se sproži po generiranju golov za vsakega igralca |
| Lastne knjižnice | `BarcelonaManager.Models`, `BarcelonaManager.Services` |

---

## Avtor

**Črt Peterlin** — R3B  
Srednja šola za kemijo, elektrotehniko in računalništvo  
April 2026

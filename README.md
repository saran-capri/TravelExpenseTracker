# TravelExpenseTracker

A cross-platform travel expense management app built with **.NET MAUI**, targeting iOS, Android, macOS, and Windows from a single codebase.

---

## Features

- User authentication (Login / Register screens)
- Home dashboard showing recent trips in a grid layout
- Trips listing with location, date range, and status badges
- MVVM architecture using CommunityToolkit.Mvvm
- Light and dark theme support
- Custom fonts (Poppins, OpenSans)
- Platform-specific refinements (e.g., borderless entry on Android)

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | .NET MAUI 10.0 |
| Language | C# 13 / .NET 10 |
| UI Pattern | MVVM |
| MVVM Toolkit | CommunityToolkit.Mvvm 8.4 |
| UI Toolkit | CommunityToolkit.Maui 14.0 |
| DI Container | Microsoft.Extensions.DependencyInjection |
| Platforms | iOS 15+, Android, macOS 15+, Windows 10 (1904+) |

---

## Project Structure

```
TravelExpenseTracker/
├── TravelExpenseTracker.sln
└── TravelExpenseTracker/
    ├── App.xaml / App.xaml.cs         # App entry point & resource merging
    ├── AppShell.xaml                  # Shell navigation structure
    ├── MauiProgram.cs                 # DI & app builder configuration
    ├── Controls/
    │   └── BorderlessEntry.cs         # Custom entry (removes Android underline)
    ├── Models/
    │   └── TripModel.cs               # Immutable trip record
    ├── Pages/
    │   ├── LoginPage.xaml             # Login screen
    │   ├── RegisterPage.xaml          # Registration screen
    │   ├── MainPage.xaml              # Home dashboard
    │   └── TripsPage.xaml             # All trips list
    ├── ViewModels/
    │   ├── LoginViewModel.cs
    │   ├── RegisterViewModel.cs
    │   ├── HomeViewModel.cs
    │   └── TripsViewModel.cs
    ├── Resources/
    │   ├── Fonts/                     # Poppins & OpenSans TTF files
    │   ├── Images/                    # PNG assets & SVG icons
    │   ├── Styles/
    │   │   ├── Colors.xaml            # Color palette
    │   │   └── Styles.xaml            # Global control styles
    │   ├── AppIcon/
    │   └── Splash/
    └── Platforms/
        ├── Android/
        ├── iOS/
        ├── MacCatalyst/
        └── Windows/
```

---

## Prerequisites

| Requirement | Version |
|---|---|
| .NET SDK | 10.0 or later |
| Visual Studio 2022 / VS Code | Latest |
| MAUI workload | Installed via `dotnet workload install maui` |
| Xcode (macOS / iOS) | 16+ |
| Android SDK | API 21+ |
| Windows SDK | 10.0.19041.0+ |

---

## Setup & Run

### 1. Clone the repository

```bash
git clone <repository-url>
cd TravelExpenseTracker
```

### 2. Install .NET MAUI workload

```bash
dotnet workload install maui
```

### 3. Restore NuGet packages

```bash
dotnet restore TravelExpenseTracker.sln
```

### 4. Run the app

#### Android

```bash
dotnet build -t:Run -f net10.0-android
```

Or launch an emulator first, then:

```bash
dotnet run --project TravelExpenseTracker -f net10.0-android
```

#### iOS (macOS only)

```bash
dotnet build -t:Run -f net10.0-ios -p:_DeviceName=:v2:udid=<simulator-udid>
```

To list available simulators:

```bash
xcrun simctl list devices
```

#### macOS Catalyst

```bash
dotnet build -t:Run -f net10.0-maccatalyst
```

#### Windows

```bash
dotnet build -t:Run -f net10.0-windows10.0.19041.0
```

---

## Running from Visual Studio

1. Open `TravelExpenseTracker.sln` in Visual Studio 2022.
2. Select the target platform from the **run target** dropdown (Android Emulator, iOS Simulator, Windows Machine, etc.).
3. Press **F5** (or click **Run**).

---

## Running from VS Code

1. Install the **C# Dev Kit** and **.NET MAUI** extensions.
2. Open the workspace folder.
3. Open the Command Palette (`Cmd+Shift+P` / `Ctrl+Shift+P`) and select `.NET: Generate Assets for Build and Debug`.
4. Choose your target framework from the debug configuration dropdown and press **F5**.

---

## Build (without running)

```bash
# Android
dotnet build TravelExpenseTracker -f net10.0-android

# iOS
dotnet build TravelExpenseTracker -f net10.0-ios

# macOS
dotnet build TravelExpenseTracker -f net10.0-maccatalyst

# Windows
dotnet build TravelExpenseTracker -f net10.0-windows10.0.19041.0
```

---

## Color Palette

| Token | Hex | Usage |
|---|---|---|
| Primary | `#3949ab` | Buttons, active tabs |
| Primary Dark | `#ac99ea` | Dark-mode primary |
| Secondary | `#DFD8F7` | Backgrounds, chips |
| Tertiary | `#2B0B98` | Accents |

---

## Roadmap

- [ ] Backend API integration
- [ ] Local database persistence (SQLite)
- [ ] Real authentication & session management
- [ ] Add / edit trip workflow
- [ ] Expense categories and totals
- [ ] Image upload / camera capture
- [ ] Settings page
- [ ] Export expense report (PDF / CSV)

---

## License

This project is for personal / portfolio use. Add a license file as needed.

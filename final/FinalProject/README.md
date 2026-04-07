# ✈️ SkyLink ATC: Air Traffic Control Simulator

**SkyLink ATC** is a high-stakes, terminal-based simulation designed to model the complexities of managing a busy airspace. As the Air Traffic Controller, your mission is to prioritize incoming flights, manage limited airport resources (Runways and Gates), and navigate unpredictable weather conditions to ensure every plane lands safely.

---

## 🚀 Overview
In this simulation, the sky is constantly changing. New flights enter your radar with varying fuel levels and emergencies. You must decide which planes land first based on a dynamic priority system while ensuring your airport has the physical capacity (runway length and gate space) to handle them.

### Key Gameplay Mechanics
* **Dynamic Airspace:** New flights are randomly generated every turn.
* **Resource Management:** Match planes to specific Runway lengths and manage limited parking Gates.
* **Environmental Factors:** Weather conditions (Clear, Rainy, Foggy, Thunderstorms) impact fuel consumption.
* **Human Factor:** Pilots have different skill levels that affect how efficiently they fly during landing.

---

## 🛠️ Technical Implementation (OOP Pillars)

This project was built using **C#** and follows the four pillars of Object-Oriented Programming:

1.  **Inheritance:** A base `Aircraft` class provides common functionality, while `Commercial`, `Cargo`, and `Emergency` subclasses inherit and extend it.
2.  **Polymorphism:** The `GetLandingPriority()` method is overridden in each subclass, allowing the `ControlTower` to sort a generic list of aircraft based on their specific type-based logic.
3.  **Encapsulation:** Class attributes (like fuel and state) are protected or private, ensuring data integrity through controlled public methods.
4.  **Abstraction:** The `Aircraft` class is defined as `abstract`, serving as a template that cannot be instantiated directly.

---

## 🗂️ Class Structure (The 10 Classes)

The system is organized into 10 distinct classes to ensure a modular and scalable design:

1.  **`Program`**: The entry point that initializes the simulation and handles the main menu.
2.  **`ControlTower`**: The central manager that tracks the airspace, runways, gates, and weather.
3.  **`Aircraft` (Abstract)**: The base class for all flight entities.
4.  **`CommercialFlight`**: Represents passenger planes with medium landing priority.
5.  **`CargoFlight`**: Represents heavy freight planes requiring longer runways.
6.  **`EmergencyFlight`**: High-priority flights (e.g., medical or mechanical failure).
7.  **`Runway`**: Manages physical landing strips with length and occupancy constraints.
8.  **`Gate`**: Manages airport parking capacity.
9.  **`Weather`**: Randomly generates atmospheric conditions and their fuel modifiers.
10. **`Pilot`**: Defines pilot skill levels that affect flight efficiency.

---

## 🎮 How to Play

### Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Instructions
1.  Clone or download the project files.
2.  Open your terminal in the project directory.
3.  Run the command:
    ```bash
    dotnet run
    ```
4.  **In-Game Commands:**
    * `land`: Attempts to land the highest-priority plane (requires a free, suitable runway and an empty gate).
    * `wait`: Skips the turn, allowing time to pass (fuel will decrease and weather may change).
    * `exit`: Closes the simulation.

---

## ⚠️ Crisis Management
If an aircraft reaches **0% Fuel**, its state changes to `Crashed`, and it is removed from the radar. Keep a close eye on the **Thunderstorm** modifier, as it can drain fuel more than twice as fast!

---

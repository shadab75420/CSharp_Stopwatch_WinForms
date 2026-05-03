# CSharp_Stopwatch_WinForms
# C# Stopwatch Application (Windows Forms)

## Problem Statement

This project implements a Stopwatch application using C# Windows Forms.
The application allows users to measure time with start, stop, reset, and lap functionalities.

The stopwatch tracks:

* Minutes
* Seconds
* Milliseconds

It provides an interactive UI for real-time time tracking.

---

## Features

* Start and Stop the stopwatch
* Reset the timer to zero
* Record lap times
* Display time in format: `MM:SS:MS`
* Real-time update using Timer control

---

## Technologies Used

* C#
* Windows Forms (WinForms)
* .NET Framework / .NET

---

## Functionality Overview

### Timer Logic

* Timer increments every 10 milliseconds
* Converts:

  * 1000 ms → 1 second
  * 60 seconds → 1 minute

### Buttons

*  **Start/Stop Button**

  * Starts or pauses the stopwatch

* **Reset Button**

  * Stops timer and resets all values to zero

* **Lap Button**

  * Records current time into lap list

---

## Code Structure

* `Form1.cs` → Main logic and UI handling
* `timer1_Tick()` → Updates time
* `btnStart_Click()` → Start/Stop logic
* `btnReset_Click()` → Reset logic
* `btnLap_Click()` → Lap recording

---

## Sample Output

00:00:00 → Initial state
00:01:25 → After running
Lap 1 - 00:01:25
Lap 2 - 00:02:10

---

## How to Run the Code

1. Open the project in Visual Studio
2. Ensure Windows Forms is selected
3. Build the solution
4. Run the application (F5)
5. Use buttons to control stopwatch



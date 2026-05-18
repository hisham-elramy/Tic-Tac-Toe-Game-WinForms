# Tic Tac Toe WinForms Game

An interactive desktop implementation of the classic Tic Tac Toe game built using C# and Windows Forms.

The project focuses on event-driven programming, UI state management, game logic implementation, and dynamic user interaction using WinForms.

In addition to the core gameplay mechanics, the application includes theme switching, dark/light mode support, visual winner highlighting, and game restart functionality.

---

# Overview

This project recreates the classic Tic Tac Toe experience in a desktop environment using WinForms.

The game supports:

- Two-player local gameplay
- Real-time winner detection
- Draw detection
- Dynamic UI updates
- Theme customization
- Dark and light mode switching

The project demonstrates practical use of:

- Event-driven architecture
- State management
- Enums and structs
- UI rendering
- Game logic implementation

---

# Features

## Core Gameplay

- Two-player turn-based gameplay
- Automatic turn switching
- Winner detection system
- Draw detection
- Invalid move prevention
- Game restart functionality

## UI Features

- Dynamic image rendering for X and O
- Winning combination highlighting
- Multiple background themes
- Dark mode / light mode switching
- Custom board drawing using Graphics API
- Responsive game status updates

## Game State Management

- Tracks current player
- Tracks play count
- Tracks winner state
- Handles game over conditions
- Prevents interaction after game completion

---

# Technologies Used

- C#
- .NET Framework
- WinForms
- GDI+ Graphics
- Event-Driven Programming
- Object-Oriented Programming (OOP)

---

# Project Structure

```text
TicTacToe/
│
├── Form1.cs
├── Resources/
├── Properties/
│
└── Assets
```

---

# Game Logic

The game uses:

- Enums for player and winner states
- Structs for storing game statistics
- Button Tag properties for board state tracking
- Dynamic image assignment for moves

Example states:

- X
- O
- Draw
- Game In Progress

The winner detection system checks:

- Rows
- Columns
- Diagonals

after every move.

---

# UI Rendering

The board is dynamically rendered using the WinForms Graphics API:

- Vertical lines
- Horizontal lines
- Rounded line caps
- Dynamic color switching based on theme mode

---

# Themes & Appearance

The game supports:

- Multiple background themes
- Dark mode
- Light mode
- Dynamic color switching

Players can switch between visual themes during gameplay.

---

# Screenshots

## Main Game Screen

(Add Screenshot Here)

## Dark Mode

(Add Screenshot Here)

## Winner Screen

(Add Screenshot Here)

## Theme Variations

(Add Screenshot Here)

---

# Learning Outcomes

This project helped strengthen practical understanding of:

- WinForms event handling
- Game loop logic
- UI state synchronization
- Structs and enums
- Graphics rendering
- Interactive desktop application development
- Conditional game workflows

---

# Future Improvements

- Add single-player mode with AI
- Add Minimax algorithm
- Add score tracking system
- Add sound effects
- Add animations
- Add online multiplayer support
- Add difficulty levels
- Improve UI responsiveness

---

# Author

Hisham Elramy

---

# Disclaimer

This project was developed for educational and learning purposes to practice desktop application development and game logic implementation using WinForms.

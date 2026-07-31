# 🎮 Tic-Tac-Toe (X-O) Game

<div align="center">

![C#](https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge&logo=csharp)
![.NET Framework](https://img.shields.io/badge/Framework-.NET%20Framework-purple?style=for-the-badge&logo=.net)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-success?style=for-the-badge)
![Desktop App](https://img.shields.io/badge/Application-Desktop-orange?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen?style=for-the-badge)
![Learning Project](https://img.shields.io/badge/Project-Learning-lightgrey?style=for-the-badge)

*A Windows Forms implementation of the classic Tic-Tac-Toe game developed as part of my C# learning journey.*

</div>

---

# 📑 Table of Contents

- [📖 Project Overview](#-project-overview)
- [🎯 Learning Objectives](#-learning-objectives)
- [✨ Features](#-features)
- [🖥 Windows Forms Concepts Applied](#-windows-forms-concepts-applied)
- [⚙️ Application Workflow](#️-application-workflow)
- [📂 Project Structure](#-project-structure)
- [💻 Technologies Used](#-technologies-used)
- [🚀 Getting Started](#-getting-started)
- [💡 Skills Demonstrated](#-skills-demonstrated)
- [📸 Screenshots](#-screenshots)
- [🔮 Future Improvements](#-future-improvements)
- [👨‍💻 Author](#-author)

---

# 📖 Project Overview

**Tic-Tac-Toe (X-O) Game** is a Windows Forms desktop application developed using **C#** and **.NET Framework**.

The project implements the classic Tic-Tac-Toe game where two players compete by placing **X** and **O** symbols on a graphical game board.

This application represents my transition from building console-based applications to developing desktop applications with graphical user interfaces.

During development, I practiced:

- Creating Windows Forms interfaces
- Handling user interactions through events
- Managing application states
- Implementing game logic
- Working with images and resources
- Applying Object-Oriented Programming concepts

---

# 🎯 Learning Objectives

The main objective of this project was to understand the fundamentals of **Windows Forms development** by creating a complete interactive desktop application.

Through this project, I practiced:

- Designing graphical user interfaces (GUI)
- Understanding event-driven programming
- Working with Windows Forms controls
- Handling button events
- Managing game states
- Separating UI logic from application logic
- Applying OOP concepts in desktop applications
- Building interactive software with user input

This project was an important step in moving from simple console applications to event-driven graphical applications.

---

# ✨ Features

## 🎮 Gameplay Features

- Two-player Tic-Tac-Toe gameplay
- Interactive game board
- X and O image rendering
- Turn management between players
- Winner detection
- Draw detection

---

## 🖥 User Interface Features

- Graphical Windows Forms interface
- Button-based interaction
- Image resources for game symbols
- Clean and simple layout
- Responsive user interaction

---

## 🔄 Game Control

- Restart game option
- Reset board state
- Start a new match without restarting the application

---

# 🖥 Windows Forms Concepts Applied

| Concept | How It Was Used |
|----------|----------------|
| **Windows Forms Controls** | Used controls such as Buttons, Labels, and PictureBoxes to build the graphical interface. |
| **Buttons** | Represented the Tic-Tac-Toe board cells and allowed players to interact with the game. |
| **Labels** | Displayed game information such as player turns and results. |
| **PictureBox** | Rendered X and O images on the game board. |
| **Images and Resources** | Stored and displayed game assets inside the application. |
| **Event Handlers** | Responded to user actions such as button clicks. |
| **Event-Driven Programming** | Built the application around user interactions instead of sequential console execution. |
| **Classes and Objects** | Organized application logic using object-oriented programming principles. |
| **Methods** | Divided functionality into reusable blocks of code. |
| **Conditional Statements** | Implemented winner checking and game decisions. |
| **Loops** | Checked board states and processed repeated operations. |
| **State Management** | Tracked player turns, board status, and game completion. |
| **GUI Design** | Created a visual interface that allows users to interact with the application. |
| **Game Logic** | Implemented rules for winning, losing, and drawing. |

---

# ⚙️ Application Workflow

The application follows this workflow:

```text
Application Starts
        │
        ▼
Load Windows Form
        │
        ▼
Initialize Game Board
        │
        ▼
Player 1 Selects A Cell
        │
        ▼
Display X Symbol
        │
        ▼
Switch Turn To Player 2
        │
        ▼
Display O Symbol
        │
        ▼
Check Game Status
        │
        ├───────────────┐
        │               │
        ▼               ▼
Winner Found       No Winner
        │               │
        ▼               ▼
Display Result     Continue Playing
        │
        ▼
Restart Game Option

# C# Console Todo List Application

A simple command-line todo list application built in C# that helps users manage their tasks.

## Features

-   Add new todos with titles and descriptions
-   Mark todos as completed
-   Display all todos with their completion status
-   Simple numbered menu interface
-   Input validation for all user interactions

## How to Use

1. Run the application
2. Choose from the following options:
    - `1`: Add a new todo
    - `2`: Mark a todo as completed
    - `3`: Display all todos
    - `4`: Exit the application

### Adding a Todo

-   Enter the title when prompted
-   Enter the description when prompted
-   The todo will be added to your list

### Marking as Completed

-   View the numbered list of todos
-   Enter the number of the todo you want to mark as completed
-   The todo's status will be updated

### Viewing Todos

Each todo is displayed with:

-   Todo number
-   Completion status ([✓] or [ ])
-   Title
-   Description

## Technical Details

Built using:

-   C# (.NET)
-   Object-Oriented Programming principles
-   Clean code practices with separate classes for:
    -   TodoItem (data model)
    -   TodoManager (business logic)
    -   Program (user interface)

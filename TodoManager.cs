using System;
using ConsoleTables;

namespace TodoApp
{
    public class TodoManager
    {
        private List<TodoItem> todos = new List<TodoItem>();

        public void AddTodo(string title, string description)
        {
            var todo = new TodoItem(title, description);
            todos.Add(todo);
        }

        public void DisplayTodos()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos found.");
                return;
            }

            Console.WriteLine("\nCurrent Todos:");
            Console.WriteLine("-------------");
            //The code below is the original code that displays the todos
            //I modified it to display the todos with a number prefix
            // that is the index of the todo in the list.
            // I use that index for the MarkAsCompleted method.
            // foreach (var todo in todos)
            // {
            //     string status = todo.IsCompleted ? "[✓]" : "[ ]";
            //     Console.WriteLine($"{status} {todo.Title}");
            //     Console.WriteLine($"   Description: {todo.Description}");
            // }
            var table = new ConsoleTable("Todo#", "Status", "Title", "Description");
            for (int i = 0; i < todos.Count; i++)
            {
                string status = todos[i].IsCompleted ? "[✓]" : "[ ]";
                table.AddRow(i + 1, status, todos[i].Title, todos[i].Description);
                // System.Console.WriteLine($"Todo#: {i + 1}");
                // Console.WriteLine($"{status} {todos[i].Title}");
                // Console.WriteLine($"   Description: {todos[i].Description}");
            }
            table.Write();
            Console.WriteLine("-------------\n");
        }

        public void MarkAsCompleted()
        {

            DisplayTodos();
            Console.WriteLine("Enter the number of the todo you want to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int todoIndex))
            {
                if (todoIndex > 0 && todoIndex <= todos.Count)
                {
                    try
                    {
                        var todo = todos[todoIndex - 1];
                        todo.IsCompleted = true;
                        System.Console.WriteLine($"Todo '{todo.Title}' marked as completed.");
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine($"Error marking todo as completed: {ex.Message}");
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid todo index.");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a valid number.");
            }


        }
    }
}
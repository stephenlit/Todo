using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            var todoManager = new TodoManager();
            var menu = new Menu();

            while (isRunning)
            {
                menu.DisplayMenu();

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                    switch (choice)
                    {
                        case 1:
                            string? title;
                            string? description;
                            do
                            {
                                Console.WriteLine("Enter your todo title");
                                title = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(title))
                                {
                                    Console.WriteLine("Invalid input. Please enter a title for your Todo: ");
                                }
                            } while (string.IsNullOrWhiteSpace(title));

                            do
                            {
                                Console.WriteLine("Enter the description of the todo");
                                description = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(description))
                                {
                                    Console.WriteLine("Invalid input. Please enter a description for your Todo: ");
                                }
                            } while (string.IsNullOrWhiteSpace(description));

                            todoManager.AddTodo(title, description);
                            break;
                        case 2:
                            todoManager.MarkAsCompleted();
                            // Console.WriteLine("Enter the title of the todo to mark as completed");
                            // string titleToComplete = Console.ReadLine() ?? "";
                            // todoManager.MarkAsCompleted(titleToComplete);
                            break;
                        case 3:
                            todoManager.DisplayTodos();
                            break;
                        case 4:
                            isRunning = false;
                            break;
                    }
                else
                {
                    System.Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                if (isRunning)
                {
                    System.Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Exiting the application...");
        }
    }
}

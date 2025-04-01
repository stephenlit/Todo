using System;

namespace TodoApp
{
    public class TodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }


        // Constructor with parameters
        public TodoItem(string title, string description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
        }
    }
}
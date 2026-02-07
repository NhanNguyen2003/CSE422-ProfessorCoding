using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Observer
{
    public class UserSubscriber : ISubscriber
    {
        public string Name { get; set; }

        public UserSubscriber(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received notification: {message}");
        }
    }
}

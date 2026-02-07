using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Models
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}

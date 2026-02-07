using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Observer
{
    public interface ISubscriber
    {
        void Update(string message);
    }
}

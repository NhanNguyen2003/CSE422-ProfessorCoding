using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Observer
{
    public class LibraryNotifier
    {
        private List<ISubscriber> subscribers = new();

        public void Subscribe(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void Unsubscribe(ISubscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void Notify(string message)
        {
            foreach (var sub in subscribers)
            {
                sub.Update(message);
            }
        }
    }
}

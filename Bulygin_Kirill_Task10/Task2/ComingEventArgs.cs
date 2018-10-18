using System;

namespace Task2
{
    public class ComingEventArgs : EventArgs
    {
        public DateTime ComingDateTime { get; }
        public ComingEventArgs(DateTime date)
        {
            ComingDateTime = date;
        }
    }
}
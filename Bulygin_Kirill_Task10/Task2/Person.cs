using System;
using System.Text.RegularExpressions;

namespace Task2
{
    public class Person
    {
        private string _name;

        public event EventHandler<ComingEventArgs> Coming;
        public event EventHandler Leaving;

        public void Welcome(Person sender, DateTime coming)
        {
            string welcome = string.Empty;
            int h = coming.Hour;
            if (h < 12)
            {
                welcome += "\'Доброе утро, ";
            }
            else if (h >= 12 && h < 17)
            {
                welcome += "\'Добрый день, ";
            }
            else
            {
                welcome += "\'Добрый вечер, ";
            }

            if (sender is Person p)
            {
                welcome += $"{p.Name}!\', - сказал {Name}";
            }
            Console.WriteLine(welcome);
        }

        public void TellGoodbye(Person sender)
        {
            string bye = "\'До свидания, ";
            if (sender is Person p)
            {
                bye += $"{p.Name}!\', - сказал {Name}.";
            }
            Console.WriteLine(bye);
        }

        protected bool CheckName(string name)
        {
            if (!Regex.IsMatch(name, @"\w{3}"))
            {
                return false;
            }

            return true;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (!CheckName(value))
                    throw new ArgumentException("At least 3 letters");
                _name = value;
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        public void EnterToOffice()
        {
            Coming?.Invoke(this, new ComingEventArgs(DateTime.Now));
        }

        public void LeaveOffice()
        {
            Leaving?.Invoke(this, new EventArgs());
        }
    }
}
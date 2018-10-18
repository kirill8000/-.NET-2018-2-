using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Office
    {
        private List<Person> _persons = new List<Person>();
        
        public void AddPerson(Person p)
        {
            p.Coming += Enter;
            p.Leaving += Exit;
        }

        private void Enter(object sender, ComingEventArgs args)
        {
            Person p = (Person) sender;
            Console.WriteLine($"[На работу пришел {p.Name}]");
            foreach (var person in _persons)
            {
                person.Welcome(p, args.ComingDateTime);
            }
            _persons.Add(p);
        }

        public void Exit(object sender, EventArgs args)
        {
            Person p = (Person)sender;
            Console.WriteLine($"[{p.Name} ушел домой]");
            _persons.Remove(p);
            foreach (var person in _persons)
            {
                person.TellGoodbye(p);
            }
        }

        public void RemovePerson(Person p)
        {
            _persons.Remove(p);
            p.Coming -= Enter;
            p.Leaving -= Exit;
        }

    }
}

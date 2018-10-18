using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();
            var p1 = new Person("Дима");
            var p2 = new Person("Илья");
            var p3 = new Person("Андрей");
            office.AddPerson(p1);
            office.AddPerson(p2);
            office.AddPerson(p3);
            p1.EnterToOffice();
            p2.EnterToOffice();
            p3.EnterToOffice();
            p2.LeaveOffice();
            p1.LeaveOffice();
            p3.LeaveOffice();
        }
    }
}

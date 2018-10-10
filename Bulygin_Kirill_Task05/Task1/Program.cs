using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                DateOfBirth = new DateTime(1999, 08, 16),
                Name = "Василий",
                Patronymic = "Владимирович",
                Surname = "Петров"
            };
            Console.WriteLine(user);
        }
    }
}

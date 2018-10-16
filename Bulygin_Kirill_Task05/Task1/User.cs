using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private DateTime _dateOfBirth;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                var now = DateTime.Now;
                if(value > now)
                    throw new ArgumentException("Age must be positive");
                _dateOfBirth = value;
            }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) age--;
                return age;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Patronymic} {Surname}\nРождён: {DateOfBirth:d}\nВозраст: {Age}";
        }
    }
}

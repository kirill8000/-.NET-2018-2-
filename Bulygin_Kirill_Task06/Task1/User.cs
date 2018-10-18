using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private DateTime _dateOfBirth;
        private string _name;
        private string _surname;
        private string _patronymic;

        protected bool CheckName(string name)
        {
            if (!Regex.IsMatch(name, @"\w{3}"))
            {
                return false;
            }

            return true;
        }

        protected int YearsCountFrom(DateTime date)
        {
            var today = DateTime.Today;
            var y = today.Year - date.Year;
            if (date > today.AddYears(-y)) y--;
            return y;
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (!CheckName(value))
                    throw new ArgumentException("At least 3 letters");
                _surname = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if(!CheckName(value))
                    throw new ArgumentException("At least 3 letters");
                _name = value;
            }
        }

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (value == null)
                {
                    _patronymic = string.Empty;
                }
                else if (!Regex.IsMatch(value, @"\w*"))
                {
                    throw new ArgumentException("Only letters possible");
                }
                else
                {
                    _patronymic = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                var now = DateTime.Now;
                if (value > now)
                    throw new ArgumentException("Age must be positive");
                _dateOfBirth = value;
            }
        }

        public int Age => YearsCountFrom(_dateOfBirth);

        public override string ToString()
        {
            return $"{Name} {Patronymic} {Surname}\nРождён: {DateOfBirth:d}\nВозраст: {Age}";
        }
    }
}

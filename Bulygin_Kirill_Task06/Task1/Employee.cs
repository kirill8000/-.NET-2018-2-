using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User
    {
        private DateTime _enrollmentDate;
        private string _position;
        public DateTime EnrollmentDate
        {
            get => _enrollmentDate;
            set
            {
                if (_enrollmentDate > DateTime.Today)
                {
                    throw new ArgumentException("In can't be in future");
                }

                _enrollmentDate = value;
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                if (!CheckName(value))
                    throw new ArgumentException("At least 3 letters");
                _position = value;
            }
        }

        public int Experience => YearsCountFrom(_enrollmentDate);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class GeometricProgression : ISeries, IIndexable
    {
        private int _currentIndex = 1;
        private readonly double _start;
        private readonly double _ratio;
        public double GetCurrent() => _start * Math.Pow(_ratio, _currentIndex - 1);

        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 1;
        }

        public GeometricProgression(double start, double ratio)
        {
            _start = start;
            _ratio = ratio;
        }

        public double this[int index]
        {
            get
            {
                if(index < 1)
                    throw new ArgumentException("Index should be positive");
                return _start * Math.Pow(_ratio, _currentIndex - 1);
            }
        }
    }
}
}

using System;


namespace Task3
{
    public class List : ISeries, IIndexable
    {
        private readonly double[] _series;
        private int _currentIndex;

        public List(double[] series)
        {
            this._series = series;
            _currentIndex = 0;
        }

        public double GetCurrent()
        {
            return _series[_currentIndex];
        }

        public bool MoveNext()
        {
            _currentIndex = _currentIndex < _series.Length - 1 ? _currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

        public double this[int index]
        {
            get
            {
                if(index < 0 || index >= _series.Length)
                    throw new ArgumentOutOfRangeException();
                return _series[index];
            }
        }
    }
}

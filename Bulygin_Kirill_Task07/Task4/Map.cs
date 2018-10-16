using System.Collections.Generic;

namespace Task4
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public bool[,] Matrix; //для аогритма пересчета траектории
        public MainCharacter MyCharacter { get; }

        private List<Character> _characters;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Matrix = new bool[width, height];
            //сгенерировать расстановку монстров и препятствий
        }

        public void Render()
        {
            foreach (var character in _characters)
            {
                character.Render();
            }
        }

        public void Update()
        {
            if (MyCharacter.XP == 0)
            {
                //game over
            }
            foreach (var character in _characters)
            {
                character.Update();
            }
        }
    }
}
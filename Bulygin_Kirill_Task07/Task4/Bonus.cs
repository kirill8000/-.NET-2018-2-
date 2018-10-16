namespace Task4
{
    public class Bonus : Character
    {
        private bool _collected = false;
        public int Value { get; }

        public Bonus(Map world, Point position, int value) : base(world, position)
        {
            Value = value;
        }

        public override void Render()
        {
            if (!_collected)
            {
                //вывести себя
            }

        }

        public override void Update()
        {
            if(_collected)
                return;
            if (World.MyCharacter.Position == Position)
            {
                World.MyCharacter.Score += Value;
                _collected = true;
            }
            
            //убраться
        }
    }
}
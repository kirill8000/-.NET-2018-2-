namespace Task4
{
    public abstract class Monster : Character
    {
        public int Damage { get; }

        protected Monster(Map world, int damage, Point position) : base(world, position)
        {
            Damage = damage;
        }

        public override void Update()
        {
            //пересчитать траекторию
        }
    }
}
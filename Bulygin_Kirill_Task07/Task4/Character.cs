namespace Task4
{
    public abstract class Character
    {
        public Point Position { get; protected set; }
        protected Map World;
        protected Character(Map world, Point position)
        {
            World = world;
            Position = position;
        }
        public abstract void Render();
        public abstract void Update();
    }
}
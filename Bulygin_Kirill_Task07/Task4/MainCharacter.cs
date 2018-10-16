namespace Task4
{
    public class MainCharacter : Character
    {
        public int XP { get; private set; }
        public int Score { get; set; }
        public void ToDamage(int xp)
        {
            if (XP <= xp) XP = 0;
            XP -= xp;
        }
        public MainCharacter(Map world, Point position) : base(world, position)
        {
        }

        public override void Render()
        {
            //рендерит себя
        }

        public override void Update()
        {
            //перемещается
        }
    }
}
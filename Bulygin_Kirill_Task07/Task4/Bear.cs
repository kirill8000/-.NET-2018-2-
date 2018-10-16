namespace Task4
{
    public class Bear : Monster
    {
        public Bear(Map world, Point position, int damage) : base(world, damage, position)
        {

        }

        public override void Render()
        {
            //рендерит себя на карте
        }
    }

}
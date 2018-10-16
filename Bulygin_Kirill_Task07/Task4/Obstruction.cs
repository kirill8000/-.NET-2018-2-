using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Obstruction : Character
    {
        public Obstruction(Map world, Point position) : base(world, position)
        {
        }

        public override void Render()
        {
           //рендерит себя на карте
        }

        public override void Update()
        {
            //ничего не делает
        }
    }
}

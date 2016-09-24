using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Player: Character
    {
        private static Pen pen = new Pen(Color.Black, 2);
        public Player(Cell position, int hitpoint): base(position, hitpoint)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, 5, 5, 3, 3);
        }

    }
}

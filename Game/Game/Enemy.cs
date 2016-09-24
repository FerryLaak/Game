using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Enemy: Character
    {
        public static Pen pen = new Pen(Color.Black, 2);
        public Enemy(Cell position, int hitpoint): base(position, hitpoint)
        {

        }

        public int Attack(int damage, Player player)
        {
            player.Hitpoint = player.Hitpoint - damage;
            return Hitpoint;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, 5, 5, 3, 3);
        }

        public int MoveToRandomPosition(int cellX, int cellY)
        {
            cellX = 5;
            cellY = 5;
            Random random = new Random();
            int outcome = random.Next(1, (cellX * cellY));
            return outcome;
        }
    }
}

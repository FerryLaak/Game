using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Enemy
    {
        int hitpoints;
        Point position;

        public void Update()
        {

        }

        public int Attack(int damage, Player player)
        {
            return damage;
        }

        public void Draw(Graphics g)
        {

        }
    }
}

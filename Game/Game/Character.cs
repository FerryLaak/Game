using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Character
    {
        private Cell position;
        private int hitpoint;

        public Cell Position { get; set; }
        public int Hitpoint { get; set; }

        public Character(Cell position, int hitpoint)
        {
            this.position = position;
            this.hitpoint = hitpoint;
        }

        public abstract void Draw(Graphics g);
    }
}

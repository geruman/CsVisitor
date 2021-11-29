using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsVisitor
{
    public abstract class AbstractEnemy
    {
        protected int life;
        protected Point position;
        public AbstractEnemy()
        {
            life = 100;
            position = new Point(0, 0);
        }
        public int GetLife()
        {
            return life;
        }
        public void Damage(int amount)
        {
            if (amount > 0)
            {
                life -= amount;
            }
        }
        public void Heal(int amount)
        {
            if (amount > 0)
            {
                life += amount;
            }
        }
        public bool IsAlive()
        {
            if (life > 0)
            {
                return true;
            }
            return false;
        }
        public Point GetPosition()
        {
            return position;
        }
        public abstract void Accept(AbstractVisitor visitor);
    }
}

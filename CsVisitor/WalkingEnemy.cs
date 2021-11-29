using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsVisitor
{
    public class WalkingEnemy : AbstractEnemy
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Walk(Point point)
        {
            this.position = point;
        }
        public override string ToString()
        {
            return "Posición: " + this.position + " Vida: " + this.life;
        }

    }
}

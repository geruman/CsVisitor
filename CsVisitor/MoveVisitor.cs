using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsVisitor
{
    public class MoveVisitor : AbstractVisitor
    {
        private Point position;
        public MoveVisitor(Point position)
        {
            this.position = position;
        }
        public override void Visit(WalkingEnemy enemy)
        {
            enemy.Walk(position);
        }

        public override void Visit(FlyingEnemy enemy)
        {
            enemy.Fly(position);
        }
    }
}

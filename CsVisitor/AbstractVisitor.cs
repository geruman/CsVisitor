using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsVisitor
{
    public abstract class AbstractVisitor
    {
        public abstract void Visit(WalkingEnemy enemy);
        public abstract void Visit(FlyingEnemy enemy);
    }
}

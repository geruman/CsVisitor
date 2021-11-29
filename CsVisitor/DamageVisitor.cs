using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsVisitor
{
    public class DamageVisitor : AbstractVisitor
    {
        private int damage;
        public DamageVisitor(int damage)
        {
            this.damage = damage;
        }
        public override void Visit(WalkingEnemy enemy)
        {
            enemy.Damage(damage);
        }

        public override void Visit(FlyingEnemy enemy)
        {
            enemy.Damage(damage);
        }
    }
}

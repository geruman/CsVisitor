using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsVisitor
{
    public class Program
    {
        //NECESITA USAR SYSTEM.DRAWING para tener acceso a POINT
        static void Main(string[] args)
        {
            WalkingEnemy walkEnemy = new WalkingEnemy();
            FlyingEnemy flyEnemy = new FlyingEnemy();
            AbstractVisitor moveVisitor = new MoveVisitor(new Point(8,21));
            AbstractVisitor damageVisitor = new DamageVisitor(15);
            Console.WriteLine("Enemigo que camina: " + walkEnemy.ToString());
            Console.WriteLine("Visitado por MoveVisitor");
            walkEnemy.Accept(moveVisitor);
            Console.WriteLine("Enemigo que camina: " + walkEnemy.ToString());
            Console.WriteLine("Visitado por DamageVisitor");
            walkEnemy.Accept(damageVisitor);
            Console.WriteLine("Enemigo que camina: " + walkEnemy.ToString());
            Console.WriteLine("Enemigo que vuela" + flyEnemy.ToString());
            Console.WriteLine("Visitado por MoveVisitor");
            flyEnemy.Accept(moveVisitor);
            Console.WriteLine("Enemigo que vuela" + flyEnemy.ToString());
            Console.WriteLine("Visitado por DamageVisitor");
            flyEnemy.Accept(damageVisitor);
            Console.WriteLine("Enemigo que vuela" + flyEnemy.ToString());
            Console.ReadKey();




        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsVisitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsVisitor.Tests
{
    [TestClass()]
    public class MoveVisitorTests
    {
        private WalkingEnemy walkingEnemy;
        private FlyingEnemy flyingEnemy;
        private AbstractVisitor visitor;
        [TestInitialize()]
        public void Initialize()
        {
            walkingEnemy = new WalkingEnemy();
            flyingEnemy = new FlyingEnemy();
            visitor = new MoveVisitor(new Point(10,15));
        }
        [TestMethod()]
        public void VisitTest()
        {
            walkingEnemy.Accept(visitor);
            Assert.AreEqual(new Point(10, 15), walkingEnemy.GetPosition());
        }

        [TestMethod()]
        public void VisitTest1()
        {
            flyingEnemy.Accept(visitor);
            Assert.AreEqual(new Point(10, 15), flyingEnemy.GetPosition());
        }
    }
}
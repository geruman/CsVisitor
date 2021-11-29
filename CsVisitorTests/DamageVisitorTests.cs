using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsVisitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsVisitor.Tests
{
    [TestClass()]
    public class DamageVisitorTests
    {
        WalkingEnemy walkingEnemy;
        FlyingEnemy flyingEnemy;
        AbstractVisitor visitor;
        [TestInitialize()]
        public void Initialize()
        {
            walkingEnemy = new WalkingEnemy();
            flyingEnemy = new FlyingEnemy();
            visitor = new DamageVisitor(10);
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            walkingEnemy = null;
            flyingEnemy = null;
            visitor = null;
        }

        [TestMethod()]
        public void VisitTest()
        {
            walkingEnemy.Accept(visitor);
            Assert.AreEqual(90, walkingEnemy.GetLife());
        }

        [TestMethod()]
        public void VisitTest1()
        {
            flyingEnemy.Accept(visitor);
            Assert.AreEqual(90, flyingEnemy.GetLife());
        }
    }
}
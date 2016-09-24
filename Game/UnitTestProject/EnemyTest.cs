using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace UnitTestProject
{
    [TestClass]
    public class EnemyTest
    {
        public object cell { get; private set; }

        [TestMethod]
        public void AttackTest()
        {
            //?
            Character player = new Character(Cell cell, 1000);
            Character enemy = new Character(Cell cell, 300);
            enemy.Attack();
            Assert.AreNotEqual(player.Hitpoint, < player.Hitpoint);
        }
        [TestMethod]
        public void MoveToRandomPositionTest()
        {
            //?
            Character enemy = new Character(Cell cell, 300);
            enemy.moveToRandomPositinon();
            Assert.AreEqual(25, 1);

            
        }
    }
}

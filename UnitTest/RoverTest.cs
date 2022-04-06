using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {
        [Test]
        public void RoverShouldBeAtPosition()
        {
            Rover rover = new Rover();
            rover.SetPosition(new Point(2, 3));
            Assert.AreEqual(new Point(2, 3), rover.GetPosition());
        }
        [Test]
        public void RoverShouldBeAtDirection()
        {
            Rover rover = new Rover();
            rover.SetDirection("E");
            Assert.AreEqual("E", rover.GetDirection());
        }

        [Test]
        public void RoverShouldMoveForwardFromNorth()
        {
            Rover rover = new Rover();
            rover.SetDirection("N");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("N", rover.GetDirection());
            Assert.AreEqual(new Point(3, 7), rover.GetPosition());
        }

        [Test]

        public void RoverShouldMoveForwardFromSouth()
        {
            Rover rover = new Rover();
            rover.SetDirection("S");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("S", rover.GetDirection());
            Assert.AreEqual(new Point(3, 5), rover.GetPosition());
        }

        [Test]
        public void RoverShouldMoveForwardFromEast()
        {
            Rover rover = new Rover();
            rover.SetDirection("E");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("E", rover.GetDirection());
            Assert.AreEqual(new Point(4, 6), rover.GetPosition());
        }

        [Test]
        public void RoverShouldMoveForwardFromWest()
        {
            Rover rover = new Rover();
            rover.SetDirection("W");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("W", rover.GetDirection());
            Assert.AreEqual(new Point(2, 6), rover.GetPosition());
        }

        [TestCase(0, 0, "N", "W")]
        [TestCase(0, 0, "W", "S")]
        [TestCase(0, 0, "S", "E")]
        [TestCase(0, 0, "E", "N")]
        public void RoverShouldTurnLeft(int x, int y, string input, string expected)
        {
            Point point = new Point(x, y);
            Rover rover = new Rover();
            rover.SetPosition(point);
            rover.SetDirection(input);

            rover.TurnLeft();

            Assert.AreEqual(expected, rover.GetDirection());
            Assert.AreEqual(point, rover.GetPosition());
        }

        [TestCase(0, 0, "N", "E")]
        [TestCase(0, 0, "E", "S")]
        [TestCase(0, 0, "S", "W")]
        [TestCase(0, 0, "W", "N")]
        public void RoverShouldTurnRight(int x, int y, string input, string expected)
        {
            Point point = new Point(x, y);
            Rover rover = new Rover();
            rover.SetPosition(point);
            rover.SetDirection(input);

            rover.TurnRight();

            Assert.AreEqual(expected, rover.GetDirection());
            Assert.AreEqual(point, rover.GetPosition());
        }
    }
}

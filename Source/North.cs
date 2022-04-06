using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    [DirectionAttribute(Constants.North)]
    class North : IDirection
    {
        public IDirection TurnLeft()
        {
            return DirectionFactory.GetDirection(Constants.West);
        }

        public IDirection TurnRight()
        {
            return DirectionFactory.GetDirection(Constants.East);
        }

        public override string ToString()
        {
            return Constants.North;
        }

        public Point MoveForward(Point point)
        {
            return new Point(point.X, point.Y + 1);
        }
    }
}

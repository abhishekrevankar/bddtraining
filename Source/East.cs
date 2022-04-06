namespace MarsRovers
{
    [DirectionAttribute(Constants.East)]
    internal class East : IDirection
    {
        public Point MoveForward(Point point)
        {
            return new Point(point.X + 1, point.Y);
        }

        public IDirection TurnLeft()
        {
            return DirectionFactory.GetDirection(Constants.North);
        }

        public IDirection TurnRight()
        {
            return DirectionFactory.GetDirection(Constants.South);
        }
        public override string ToString()
        {
            return Constants.East;
        }
    }
}
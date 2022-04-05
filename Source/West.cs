namespace MarsRovers
{
    [DirectionAttribute(Constants.West)]
    internal class West : IDirection
    {
        public Point MoveForward(Point point)
        {
            return new Point(point.X - 1, point.Y);
        }

        public IDirection TurnLeft()
        {
            return DirectionFactory.GetDirection(Constants.South);
        }

        public IDirection TurnRight()
        {
            return DirectionFactory.GetDirection(Constants.North);
        }
        public override string ToString()
        {
            return Constants.West;
        }
    }
}
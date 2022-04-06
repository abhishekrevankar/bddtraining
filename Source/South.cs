namespace MarsRovers
{
    [DirectionAttribute(Constants.South)]
    internal class South : IDirection
    {
        public Point MoveForward(Point point)
        {
            return new Point(point.X, point.Y - 1);
        }

        public IDirection TurnLeft()
        {
            return DirectionFactory.GetDirection(Constants.East);
        }

        public IDirection TurnRight()
        {
            return DirectionFactory.GetDirection(Constants.West);
        }
        public override string ToString()
        {
            return Constants.South;
        }
    }
}
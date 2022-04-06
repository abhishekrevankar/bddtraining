using System;

namespace MarsRovers
{
    public class Rover
    {
        private Point _position;
        private IDirection _direction;

        internal void SetPosition(Point position)
        {
            _position = position;
        }

        internal Point GetPosition()
        {
            return _position;
        }

        internal void SetDirection(string direction)
        {
            _direction = DirectionFactory.GetDirection(direction);
        }

        internal string GetDirection()
        {
            return _direction.ToString();
        }

        internal void Move()
        {
            _position = _direction.MoveForward(_position);
        }

        internal void TurnLeft()
        {
            _direction = _direction.TurnLeft();
        }

        internal void TurnRight()
        {
            _direction = _direction.TurnRight();
        }
    }
}
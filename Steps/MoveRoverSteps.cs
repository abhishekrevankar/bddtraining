using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    class MoveRoverSteps
    {
        private readonly RoverTestContext _roverContext;
        public MoveRoverSteps(RoverTestContext roverContext)
        {
            _roverContext = roverContext;
        }
        [Given(@"Rover is at (\d+), (\d+)")]
        public void GivenRoverIsAt(int x, int y)
        {
            Point position = new Point(x, y);
            _roverContext._rover = new Rover();
            _roverContext._rover.SetPosition(position);
        }

        [Given(@"rover is pointing towards ([NEWS]{1})")]
        public void GivenRoverIsPointingTowardsDirection(string direction)
        {
            _roverContext._rover.SetDirection(direction);
        }

        [When(@"rover moves forward")]
        public void WhenRoverMovesForward()
        {
            _roverContext._rover.Move();
        }

        [Then(@"rover should be at (\d+), (\d+)")]
        public void ThenRoverShouldBeAt(int x, int y)
        {
            _roverContext._rover.GetPosition().Should().Be(new Point(x, y));
        }

        [Then(@"rover should be facing ([NEWS]{1})")]
        public void ThenRoverShouldBeFacingE(string direction)
        {
            _roverContext._rover.GetDirection().Should().Be(direction);
        }
    }
}

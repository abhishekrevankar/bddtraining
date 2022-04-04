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
        private readonly ScenarioContext _scenarioContext;
        private Rover _rover;
        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Rover is at (\d+), (\d+)")]
        public void GivenRoverIsAt(int x, int y)
        {
            Point position = new Point(x, y);
            _rover = new Rover();
            _rover.SetPosition(position);
        }

        [Given(@"rover is pointing towards ([NEWS]{1})")]
        public void GivenRoverIsPointingTowardsDirection(string direction)
        {
            _rover.SetDirection(direction);
        }

        [When(@"rover moves forward")]
        public void WhenRoverMovesForward()
        {
            _rover.Move();
        }

        [Then(@"rover should be at (\d+), (\d+)")]
        public void ThenRoverShouldBeAt(int x, int y)
        {
            _rover.GetPosition().Should().Be(new Point(x, y));
        }

        [Then(@"rover should be facing ([NEWS]{1})")]
        public void ThenRoverShouldBeFacingE(string direction)
        {
            _rover.GetDirection().Should().Be(direction);
        }
    }
}

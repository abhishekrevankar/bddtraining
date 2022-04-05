using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class DirectionAttribute : Attribute
    {
        public string Direction { get; private set; }

        public DirectionAttribute(string direction)
        {
            Direction = direction;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    static class DirectionFactory
    {
        static Dictionary<string, Type> _directions;
        static DirectionFactory()
        {
            Initialize();
        }

        private static void Initialize()
        {
            Type attributeType = typeof(DirectionAttribute);
            var directionAtrributes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                      from type in assembly.GetTypes()
                                      let attributes = type.GetCustomAttributes(attributeType, true)
                                      where attributes.Any()
                                      select
                                          new KeyValuePair<String, Type>(((DirectionAttribute)attributes.First())
                                          .Direction, type);

            _directions = new Dictionary<string, Type>();
            foreach (var item in directionAtrributes)
                _directions.Add(item.Key, item.Value);
        }

        public static IDirection GetDirection(string direction)
        {
            IDirection obj = (IDirection)Activator.CreateInstance(_directions[direction]);
            return obj;
        }
    }
}

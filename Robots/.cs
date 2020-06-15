using System;
using System.Collections.Generic;
using System.Linq;

namespace Robots
{
    public class Robot
    {
        public string Name;
        public Type Type;
        public Robot(List<Robot> robots)
        {
            do
            {
                this.Name = string.Empty;
                this.Name += (char)new Random().Next(65, 91);
                this.Name += (char)new Random().Next(65, 91);
                this.Name += (char)new Random().Next(48, 58);
                this.Name += (char)new Random().Next(48, 58);
                this.Name += (char)new Random().Next(48, 58);
            } while (robots.Where(x => x.Name == this.Name).First() == null);

        }
    }
    public enum Type { Translator, CoffeeMaking, Bartender }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots;
using Roboty;
namespace Roboty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            for (int i = 0; i < 100; i++)
            {
                Robot robot = new Robot(robots);
                robots.Add(robot);
            }
            robots[new Random().Next(0, 100)].Reset(robots);
            foreach(Robot a in robots)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
        }
    }
}

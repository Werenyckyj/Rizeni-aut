using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řízení_aut
{
    public class AutonomousCar
    {
        public double speed = 90;
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public string Condition { get; set; }
        public string Route { get; set; }
        public AutonomousCar()
        {
            RouteGenerator();
        }
        public void RouteGenerator()
        {
            string s = "0";
            Random r = new Random();
            while (s.Length < 10)
            {
                s += r.Next(0, 2);
            }
            Route = s;
            PositionX = r.Next(0,100);
            PositionY = r.Next(0,100);
        }
    }
}

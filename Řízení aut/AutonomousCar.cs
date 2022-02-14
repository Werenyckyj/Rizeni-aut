using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řízení_aut
{
    public class AutonomousCar
    {
        public Random r = new Random();
        public double Speed { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public int Condition  { get; set; }
        public bool Lights { get; set; }
        public string Route { get; set; }
        public int Distance { get; set; }
        public string Weather { get; set; }
        public int Road { get; set; }
        public AutonomousCar()
        {
            WeatherStation station = new WeatherStation();
            Distance = r.Next(20,50);
            RouteGenerator();
            PositionGenerator();
            for (int i = 0; i < 10; i++)
            {
                char route;
                route = Route[i];
                Road = Convert.ToInt32(route);
                Distance -= 1;
                Speed = 90;
                Lights = false;
                if (Route[i]==2)
                {
                    int x = station.WeatherGenerator();
                    switch (x)
                    {
                        case 0: Weather = "Slunečno"; break;
                        case 1: Speed = 70; Weather = "Déšť"; break;
                        case 2: Speed = 85; Weather = "Zataženo"; break;
                        case 3: Speed = 60; Weather = "Mlhavo"; break;
                        case 4: Speed = 30; Weather = "Sníh"; break;
                    }
                }
                else if (Route[i] == 1)
                {
                    Lights = true;
                }

                if (X() == 0)
                {
                    Condition = 0;
                }
                else if (X() == 1)
                {
                    Condition = 1;
                }
                else
                {
                    Condition = 2;
                }

                if (Distance==0)
                {
                    break;
                }

                if (i==9)
                {
                    RouteGenerator();
                    i = 0;
                }
            }
        }
        public void RouteGenerator()
        {
            string s = "0";
            while (s.Length < 10)
            {
                int i = r.Next(0, 9);
                if (i<5)
                {
                    s += 0;
                }
                else if (i<7)
                {
                    s += 1;
                }
                else
                {
                    s += 2;
                }
                
            }
            Route = s;
        }
        public void PositionGenerator()
        {
            PositionX = r.Next(0, 100);
            PositionY = r.Next(0, 100);
        }
        public int X()
        {
            int x = 0;
            int i = r.Next(0, 19);
            if (i < 16)
            {
                x = 0;
            }
            else if (i < 19)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }
            return x;
        }
    }
}

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
        public int ID { get; set; }
        public double Speed { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public int Condition  { get; set; }
        public bool Lights { get; set; }
        public int Road { get; set; }
        public int Distance { get; set; }
        public string Weather { get; set; }
        public AutonomousCar(int id)
        {
            ID = id;
            WeatherStation station = new WeatherStation();
            ControlStation controlStation = new ControlStation();
            Distance = r.Next(20,50);
            RoadGenerator();
            PositionGenerator();
            InitCars();

            int i = controlStation.i;
            Distance -= 1;
            Speed = 90;
            Lights = false;
            if (Road == 2)
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
            else if (Road == 1)
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
        }
        public void RoadGenerator()
        {
            int j;
            int i = r.Next(0, 9);
            if (i < 5)
            {
                j = 0;
            }
            else if (i < 7)
            {
                j = 1;
            }
            else
            {
                j = 2;
            }
            Road = j;
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

        public static List<AutonomousCar> cars = new List<AutonomousCar>();
        public void InitCars()
        {
            for (int ID = 0; ID < 5; ID++)
            {
                AutonomousCar c0 = new AutonomousCar(ID);
                cars.Add(c0);
            }         
        }
    }
}

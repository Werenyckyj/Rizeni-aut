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
            ControlStation controlStation = new ControlStation();
            Distance = r.Next(20,50);
            RoadGenerator();
            PositionGenerator();

            int i = controlStation.i;

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
    }
}

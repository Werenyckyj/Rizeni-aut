using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Řízení_aut
{
    class ControlStation
    {
        public int i;
        public void FullInfo(ListView lv_cars, Label lb_speed, Label lb_distance, Label lb_condition, Label lb_weather, Image img0, Image img1, Image img2)
        {
            int index = lv_cars.SelectedIndex;
            AutonomousCar c = AutonomousCar.cars[index];
            while (c.Distance>0)
            {         
                this.i = i++;
                c.RoadGenerator();
                lb_speed.Content = $"Rychlost: {c.Speed.ToString()} km/h";
                string con = string.Empty;
                switch (c.Condition)
                {
                    case 0: con = "V pořádku"; break;
                    case 1: con = "Porucha světel"; LightDefekt(); break;
                    case 2: con = "Porucha motoru"; EngineDefekt(); break;
                }
                lb_distance.Content = $"Vzdálenost: {c.Distance} km";
                lb_condition.Content = $"Stav: {con}";
                lb_weather.Content = $"Počasí: {c.Weather}";
                string road = string.Empty;
                switch (c.Road)
                {
                    case 48: road = "Silnice"; break;
                    case 1: road = "Tunel"; break;
                    case 2: road = "Most"; break;
                }
                c.RoadGenerator();
                System.Threading.Thread.Sleep(1000);
            }
            //AUTO DOJELO
        }
        private void LightDefekt()
        {
            Random r = new Random();
            int i = r.Next(1, 5);
            //dojede do servisu
        }
        private void EngineDefekt()
        {
            //speed = 0, vše zastvit
        }
    }
}

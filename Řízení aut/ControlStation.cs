using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Řízení_aut
{
    class ControlStation
    {
        public int i;
        public void FullInfo(ListView lv_cars, Label lb_speed, Label lb_distance, Label lb_condition, Label lb_weather, Image img0, Image img1, Image img2)
        {
            int index = lv_cars.SelectedIndex;
            AutonomousCar c = cars[index];
            while (c.Distance>0)
            {         
                this.i = i++;
                c.RoadGenerator();
                c.Distance -= 1;
                string con = string.Empty;
                switch (c.Condition)
                {
                    case 0: con = "V pořádku"; break;
                    case 1: con = "Porucha světel"; LightDefekt(); break;
                    case 2: con = "Porucha motoru"; EngineDefekt(); break;
                }
                c.RoadGenerator();
                c.Speed = 90;
                c.Lights = false;
                if (c.Road == 2)
                {
                    img2.Source = img1.Source; img1.Source = img0.Source;
                    img0.Source = new BitmapImage(new Uri(@"/Images/bridge.jpg", UriKind.Relative));
                    WeatherStation station = new WeatherStation();
                    int x = station.WeatherGenerator();
                    switch (x)
                    {
                        case 0: c.Weather = "Slunečno"; break;
                        case 1: c.Speed = 70; c.Weather = "Déšť"; break;
                        case 2: c.Speed = 85; c.Weather = "Zataženo"; break;
                        case 3: c.Speed = 60; c.Weather = "Mlhavo"; break;
                        case 4: c.Speed = 30; c.Weather = "Sníh"; break;
                    }
                }
                else if (c.Road == 1)
                {
                    c.Lights = true;
                    img2.Source = img1.Source; img1.Source = img0.Source;
                    img0.Source = new BitmapImage(new Uri(@"/Images/tunnel.jpg", UriKind.Relative));
                }
                else
                {
                    img2.Source = img1.Source; img1.Source = img0.Source;
                    img0.Source = new BitmapImage(new Uri(@"/Images/road.jpg", UriKind.Relative));
                }
                lb_speed.Content = $"Rychlost: {c.Speed.ToString()} km/h";
                lb_distance.Content = $"Vzdálenost: {c.Distance} km";
                lb_condition.Content = $"Stav: {con}";
                lb_weather.Content = $"Počasí: {c.Weather}";
            }
            img0.Visibility = System.Windows.Visibility.Hidden;
        }

        public static List<AutonomousCar> cars = new List<AutonomousCar>(); public int ID = 0;
        public void InitCars()
        {
            AutonomousCar c0 = new AutonomousCar(ID);
            while (ID<5)
            {
                cars.Add(c0);
                ID++;
            }
            /*for (int ID = 0; ID < 5; ID++)
            {
                AutonomousCar c0 = new AutonomousCar(ID);
                cars.Add(c0);
            }*/       
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

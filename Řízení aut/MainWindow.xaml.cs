using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Řízení_aut
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AutonomousCar c = new AutonomousCar();
            lb_speed.Content = $"Rychlost: {c.Speed.ToString()} km/h";
            string con = string.Empty;
            switch (c.Condition)
            {
                case 0: con = "V pořádku"; break;
                case 1: con = "Porucha světel"; break;
                case 2: con = "Porucha motoru"; break;
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
            lb_road.Content = road;
        }
    }
}

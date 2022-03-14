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
            ControlStation cs = new ControlStation();
            cs.InitCars();
            lv_cars.ItemsSource = ControlStation.cars;
        }

        private void lv_cars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ControlStation cs = new ControlStation();
            cs.FullInfo(lv_cars ,lb_speed, lb_distance, lb_condition, lb_weather, img0, img1, img2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řízení_aut
{
    public class WeatherStation
    {
        public Random r = new Random();
        public int Weather = r.Next(0, 4);
    }
}

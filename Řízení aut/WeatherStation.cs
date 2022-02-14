using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řízení_aut
{
    public class WeatherStation
    {
        public int WeatherGenerator()
        {
            Random r = new Random();
            return r.Next(0, 4);
        }
    }

}

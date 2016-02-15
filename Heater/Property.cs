using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Property
    {
        private double heater { get; set; }
        private double humidity { get; set; }

        public double Heater
        {
            get
            {
                return heater;
            }

            set
            {
                if (value <= 120)
                    heater = value;
            }

        }

        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                if (value <= 100)
                    humidity = value;
            }
        }
        public double Value { get; set; }

        public string SetTemperature(double value)
        {
           Heater = value;
            return Heater.ToString();
        }

        public string SetHumidity(double value)
        {
            Humidity = value;
            return Humidity.ToString();
        }
    }
}
    

   
    
    


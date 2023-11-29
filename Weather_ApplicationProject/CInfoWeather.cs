//Nikiwile Shaun Tibane
//GitHub project
using System.Collections.Generic;

namespace Weather_ApplicationProject
{
    class CInfoWeather // not necessary check it out later
    {
        public class Coordinates
        {
            //private set, make the property private 
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class Weather 
        {
            public string sMain { get; set; }
            public string sDescription { get; set; }
            public string sIcon { get; set; }
        }
        public class Main
        {
            public double temp { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            //double feels_like { get; set; }
            //double temp_min { get; set; }
            //double temp_max { get; set; }

        }
        public class Wind
        {
            public double speed { get; set; }
            //int degree { get; set; }
        }
        public class System 
        {
            public string country { get; set; }
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }
        public class root
        {
            public Coordinates coordinates { get; set; }
            public List<Weather> lstWeather { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public System system { get; set; }

        }
    }
}

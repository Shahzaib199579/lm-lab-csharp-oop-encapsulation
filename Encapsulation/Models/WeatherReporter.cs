using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private const string LONDON = "London";
        private const string CALIFORNIA = "California";
        private const string CAPE_TOWN = "Cape Town";
        private const int THIRTY = 30;
        private const int TEN = 10;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string Print()
        {
            double newTemp = (9.0 / 5.0) * _temperature + 32;
            return $"I am in {_location} and it is {Check1()}. {Check2()}. The temperature in Fahrenheit is {newTemp}.";
        }

        private string Check1()
        {
            if (_location == LONDON)
            {

                return "🌦";

            }
            else if (_location == CALIFORNIA)
            {

                return "🌅";

            }
            else if (_location == CAPE_TOWN)
            {

                return "🌤";

            }
            return "🔆";
        }

        private string Check2()
        {
            if (_temperature > THIRTY)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature < TEN)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}


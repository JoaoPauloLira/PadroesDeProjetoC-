using Padroes_de_Projeto.WeatherData_Observer.Interfaces;
using System;

namespace Padroes_de_Projeto.WeatherData_Observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly Subject _weatheData;

        public CurrentConditionsDisplay(Subject weatheData)
        {
            _weatheData = weatheData;
            _weatheData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Temperatura: {_temperature}, Umidade: {_humidity}");
        }
    }
}

using Padroes_de_Projeto.WeatherData_Observer.Interfaces;
using System.Collections.Generic;

namespace Padroes_de_Projeto.WeatherData_Observer
{
    public class WeatherData : Subject
    {
        private readonly IList<Observer> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}

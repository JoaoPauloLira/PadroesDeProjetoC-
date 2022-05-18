namespace Padroes_de_Projeto.WeatherData_Observer.Interfaces
{
    public interface Subject
    {
        public void RegisterObserver(Observer observer);
        public void RemoveObserver(Observer observer);
        public void NotifyObservers();
    }
}

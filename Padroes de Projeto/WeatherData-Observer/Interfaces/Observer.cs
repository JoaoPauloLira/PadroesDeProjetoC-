namespace Padroes_de_Projeto.WeatherData_Observer.Interfaces
{
    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure);
    }
}

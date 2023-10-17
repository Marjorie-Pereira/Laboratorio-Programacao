class ConversorTemperatura
{
    public void ConverterParaFahrenheit()
    {
        double temperaturaCelsius = 25;
        double resultado = temperaturaCelsius * 33.8;
        Console.WriteLine("Temperatura em Fahrenheit: " + Math.Round(resultado) + "°F");
    }
}
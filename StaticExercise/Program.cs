namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(54);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(12);

            Console.WriteLine($"{celsius} degrees celsius");
            Console.WriteLine($"{fahrenheit} degrees fahrenheit");
        }
    }
}

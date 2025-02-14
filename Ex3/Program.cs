// See https://aka.ms/new-console-template for more information
using Classes;
using Classes.Models;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
PlanetCatalog planetCatalog = new PlanetCatalog();
try
{
    int counter = 0;
    Func<string, string> checkingRequests = _ =>
    {
        counter++;
        if(counter == 3)
            return "Вы спрашиваете слишком часто";
        return null;
    };

    Console.WriteLine("Первая серия проверок:");
    string[] planetToFind = { "Earth", "Limonia", "Mars" };
    foreach (var item in planetToFind)
    {
        var result = PlanetCatalog.GetPlanet(item, checkingRequests);

        if (string.IsNullOrEmpty(result.Item3))
            Console.WriteLine($"Планета: {item}, Порядковый номер: {result.Item1}, Длина экватора: {result.Item2}");
        else
            Console.WriteLine($"Ошибка: {result.Item3}");
    }


    // Дополнительное задание
    Console.WriteLine("\nВторая серия проверок:");
    Func<string, string> checkPlanents = planetName =>
    {
        if (planetName.Equals("Limonia"))
            return "Это запретная планета";
        return null;
    };

    string[] planetsToCheck = { "Earth", "Limonia", "Mars" };
    foreach (var item in planetsToCheck)
    {
        var result = PlanetCatalog.GetPlanet(item, checkPlanents);
        if (string.IsNullOrEmpty(result.Item3))
            Console.WriteLine($"Планета: {item}, Порядковый номер: {result.Item1}, Длина экватора: {result.Item2}");
        else
            Console.WriteLine($"Ошибка: {result.Item3}");
    }


}
catch (Exception ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}
Console.ReadLine();
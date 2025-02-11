// See https://aka.ms/new-console-template for more information
using Classes;
using Classes.Models;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
PlanetCatalog planetCatalog = new PlanetCatalog();
try
{
    string[] planetToFind = { "Earth", "Limonia", "Mars"};
    foreach(var item in planetToFind)
    {
        var result = PlanetCatalog.GetPlanet(item, (planetName) =>
        {
            if (Config.couter == 3)
            {
                Config.couter = 0;
                return "Вы спрашиваете слишком часто";
            }
            Config.couter++;
            return planetName;
        });
        if (string.IsNullOrEmpty(result.Item3))
            Console.WriteLine($"Планета: {item}, Порядковый номер: {result.Item1}, Длина экватора: {result.Item2}");
        else
            Console.WriteLine($"Ошибка: {result.Item3}");
    }

    //задание*
    Console.WriteLine("\nЗадание со звёздочкой");
    foreach(var item in planetToFind)
    {
        var result = PlanetCatalog.GetPlanet(item, (planetName) =>
        {
            if (Config.couter == 3)
            {
                Config.couter = 0;
                return "Вы спрашиваете слишком часто";
            }
            if (planetName == "Limonia")
                return "Это запретная планета";

            Config.couter++;
            return null;
        });


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
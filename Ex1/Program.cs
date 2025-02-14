
Console.WriteLine("Hello, World!");
dynamic venus = new
{
    Name = "Венера",
    OrderNum = 2,
    EquatorLength = 38025,
    PreviousPlanet = "Венера",
};

dynamic earth = new
{
    Name = "Земля",
    OrderNum = 3,
    EquatorLength = 40075,
    PreviousPlanet = venus
};

var mars = new
{
    Name = "Марс",
    OrderNum = 4,
    EquatorLength = 21344,
    PreviousPlanet = earth
};

var venus2 = new
{
    Name = "Венера",
    OrderNum = 2,
    EquatorLength = 38025,
    PreviousPlanet = venus,
};

List<dynamic> planets = new List<dynamic> { venus, earth, mars, venus2 };
foreach(var item in planets) 
    PrintPlanet(item, venus);


Console.WriteLine(new string('-', 50));
Console.WriteLine("Сравнение с Object");
Console.WriteLine(new string('-', 50) + "\n");

foreach(var item in planets)
    PrintPlanetObject(item, venus);

Console.ReadKey();


static void PrintPlanet(dynamic planet, dynamic venus)
{
    Console.WriteLine($"Планета: {planet.Name}");
    Console.WriteLine($"Порядковый номер: {planet.OrderNum}");
    Console.WriteLine($"Длина экватора: {planet.EquatorLength} км");
    Console.WriteLine($"Предыдущая планета: {planet.PreviousPlanet}");

    if (planet.Equals(venus))
        Console.WriteLine("Равны\n");
    else
        Console.WriteLine("Не равны\n");

}

static void PrintPlanetObject(object planet, object venus)
{
    Console.WriteLine($"Планета: {planet}");
    Console.WriteLine($"Порядковый номер: {planet}");
    Console.WriteLine($"Длина экватора: {planet} км");
    Console.WriteLine($"Предыдущая планета: {planet}");

    if (planet.Equals(venus))
        Console.WriteLine("Равны\n");
    else
        Console.WriteLine("Не равны\n");

}
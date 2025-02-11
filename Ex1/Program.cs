
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

Console.WriteLine($"Сравнение планеты: {venus.Name} c Венерой");
PrintPlanet(venus, venus);

Console.WriteLine($"Сравнение планеты: {earth.Name} c Венерой");
PrintPlanet(earth, venus);

Console.WriteLine($"Сравнение планеты: {mars.Name} c Венерой");
PrintPlanet(mars, venus);

Console.WriteLine($"Сравнение планеты: {venus2.Name} c Венерой");
PrintPlanet(venus2, venus);



Console.WriteLine(new string('-', 50));
Console.WriteLine("Сравнение с Object");
Console.WriteLine(new string('-', 50) + "\n");



Console.WriteLine($"Сравнение планеты: {venus.Name} c Венерой");
PrintPlanetObject(venus, venus);

Console.WriteLine($"Сравнение планеты: {earth.Name} c Венерой");
PrintPlanetObject(earth, venus);

Console.WriteLine($"Сравнение планеты: {mars.Name} c Венерой");
PrintPlanetObject(mars, venus);

Console.WriteLine($"Сравнение планеты: {venus2.Name} c Венерой");
PrintPlanetObject(venus2, venus);



Console.ReadKey();


static void PrintPlanet(dynamic platen, dynamic venus)
{
    Console.WriteLine($"Планета: {platen.Name}");
    Console.WriteLine($"Порядковый номер: {platen.OrderNum}");
    Console.WriteLine($"Длина экватора: {platen.EquatorLength} км");
    Console.WriteLine($"Предыдущая планета: {platen.PreviousPlanet}");

    if (platen.Equals(venus))
        Console.WriteLine("Равны\n");
    else
        Console.WriteLine("Не равны\n");

}

static void PrintPlanetObject(object platen, object venus)
{
    Console.WriteLine($"Планета: {platen}");
    Console.WriteLine($"Порядковый номер: {platen}");
    Console.WriteLine($"Длина экватора: {platen} км");
    Console.WriteLine($"Предыдущая планета: {platen}");

    if (platen.Equals(venus))
        Console.WriteLine("Равны\n");
    else
        Console.WriteLine("Не равны\n");

}
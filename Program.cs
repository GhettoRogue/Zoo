﻿using ZooParkApp.zoo;

var zoo = new Zoo() {TotalAviaries = 2};

do
{
    var exit = false;

    Console.WriteLine("Выберите тип вольера:");
    Console.WriteLine("1. Водный");
    Console.WriteLine("2. Сухопутный");
    Console.WriteLine("0. Завершить добавление вольеров");
    var inputAviary = Console.ReadLine();
    var aviaryType = AviaryType.Unknown;
    switch (inputAviary)
    {
        case "1": // 1. Водный
            aviaryType = AviaryType.Aqua;
            break;
        case "2": // 2. Сухопутный
            aviaryType = AviaryType.Land;
            break;
        case "0": // 0. Завершить добавление вольеров
            exit = true;
            break;
    }

    if (exit) break;

    Console.Write("Введите название вольера:");
    var name = Console.ReadLine();
    Console.Write("Введите количество животных:");
    var count = Convert.ToInt32(Console.ReadLine());
    var result = zoo.AddAviary(name, count, aviaryType);
    Console.WriteLine(result ? "Вольер успешно добавлен" : "Ошибка добавления вольера");
} while (true);

do
{
    var exit = false;

    Console.WriteLine("Выберите животное для добавления в вольер:");
    Console.WriteLine("1. Рыба");
    Console.WriteLine("2. Птица");
    Console.WriteLine("3. Млекопитающее");
    Console.WriteLine("4. Насекомое");
    Console.WriteLine("0. Завершить добавление животных");

    var inputAnimal = Console.ReadLine();
    var animalType = AnimalType.Unknown;
    switch (inputAnimal)
    {
        case "1": // 1. Рыба
            animalType = AnimalType.Fish;
            break;
        case "2": // 2. Птица
            animalType = AnimalType.Bird;
            break;
        case "3": // 3. Млекопитающее
            animalType = AnimalType.Mammalia;
            break;
        case "4": // 4. Насекомое
            animalType = AnimalType.Insect;
            break;
        case "0": // 0. Завершить добавление животных
            exit = true;
            break;
    }

    if (exit) break;

    Console.Write("Введите вид животного:");
    var kind = Console.ReadLine();

    Console.Write("Введите название вольера:");
    var aviaryName = Console.ReadLine();
    var aviary = zoo.Aviaries.Single(a => a.Name == aviaryName);

    var result = zoo.AddAnimal(kind, animalType, aviary);

    Console.WriteLine(result ? "Животное успешно добавлено" : "Ошибка добавления животного");
} while (true);

foreach (var aviary in zoo.Aviaries)
{
    Console.WriteLine($"{aviary.GetType().Name}: total animals - {aviary.TotalCount}");
    foreach (var animal in aviary.Animals) Console.WriteLine($"{animal.GetType().Name} -> {animal.Kind}");
}
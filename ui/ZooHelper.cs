using ZooParkApp.models.animals;
using ZooParkApp.models.aviaries;
using ZooParkApp.zoo;

namespace ZooParkApp.ui;

public static class ZooHelper
{
    public static void PrintAnimal(Animal animal)
    {
        ConsoleHelper.PrintLine($"{animal.GetType().Name}: {animal.Kind}");
    }
    
    public static void PrintAviary(Aviary aviary)
    {
        ConsoleHelper.PrintLine($"{aviary.GetType().Name}: total animals - {aviary.TotalCount}");
        foreach (var animal in aviary.Animals)
        {
            PrintAnimal(animal);
        }
    }

    public static void PrintAnimals(IEnumerable<Animal> animals)
    {
        if (!animals.Any())
        {
            ConsoleHelper.PrintError("В зоопарке нет животных");
            return;
        }
        
        foreach (var animal in animals)
        {
            PrintAnimal(animal);
        }
    }

    public static void PrintAviaries(IEnumerable<Aviary> aviaries)
    {
        if (!aviaries.Any())
        {
            ConsoleHelper.PrintError("В зоопарке нет вольеров");
            return;
        }
        
        foreach (var aviary in aviaries)
        {
            PrintAviary(aviary);
        }
    }

    public static void PrintMenuAnimals()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Тип животного:");
        Console.WriteLine("1. Рыба");
        Console.WriteLine("2. Птица");
        Console.WriteLine("3. Млекопитающее");
        Console.WriteLine("4. Насекомое");
        Console.WriteLine("0. Завершить добавление животных");
        Console.ResetColor();
    }
    public static void PrintMenuAviaries()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Тип вольера:");
        Console.WriteLine("1. Водный");
        Console.WriteLine("2. Сухопутный");
        Console.WriteLine("0. Завершить добавление вольеров");
        Console.ResetColor();
    }

    public static void AddAviaries(Zoo zoo)
    {
        var menuAviaries = new Dictionary<string, AviaryType>()
        {
            {"1", AviaryType.Aqua},
            {"2", AviaryType.Land}
        };
        
        while (true)
        {
            ConsoleHelper.SleepAndClear();
            
            PrintMenuAviaries();
            
            var inputAviary = ConsoleHelper.InputString("Введите тип вольера");
            if (inputAviary == "0") return;
            var aviaryType = menuAviaries[inputAviary];
    
            var name = ConsoleHelper.InputString("Введите название вольера:");
            var count = ConsoleHelper.InputInt("Введите количество животных:");
            var result = zoo.AddAviary(name, count, aviaryType);
            if (result)
            {
                ConsoleHelper.PrintLine("Вольер успешно добавлен");
            }
            else
            {
                ConsoleHelper.PrintError("Ошибка добавления вольера");
            }
        }
    }
    
    public static void AddAnimals(Zoo zoo)
    {
        var menuAnimals = new Dictionary<string, AnimalType>()
        {
            {"1", AnimalType.Fish},
            {"2", AnimalType.Bird},
            {"3", AnimalType.Mammalia},
            {"4", AnimalType.Insect}
        };
        
        while (true)
        {
            ConsoleHelper.SleepAndClear();
            
            PrintMenuAnimals();
            
            var inputAnimal = ConsoleHelper.InputString("Выберите животное для добавления в вольер:");
            if (inputAnimal == "0") return;
            var animalType = menuAnimals[inputAnimal];
    
            var kind = ConsoleHelper.InputString("Введите вид животного:");
            var aviaryName = ConsoleHelper.InputString("Введите название вольера:");
            var aviary = zoo.Aviaries.SingleOrDefault(a => a.Name == aviaryName);

            if (aviary is null)
            {
                ConsoleHelper.PrintError("Неправильно указан вольер");
            }

            var result = zoo.AddAnimal(kind, animalType, aviary);
            if (result)
            {
                ConsoleHelper.PrintLine("Животное успешно добавлено");
            }
            else
            {
                ConsoleHelper.PrintError("Ошибка добавления животного");
            }
        }
    }
}
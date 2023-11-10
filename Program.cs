using ZooParkApp.animals;
using ZooParkApp.aviaries;
using ZooParkApp.creators;
using ZooParkApp.creators.aviaries;

AnimalCreator animalCreator = null;
AviaryCreator aviaryCreator = null;

List<Aviary> aviaries = new List<Aviary>();

do
{
    bool exit = false;
    Console.WriteLine("Выберите тип вольера:");
    Console.WriteLine("1. Водный");
    Console.WriteLine("2. Сухопутный");
    Console.WriteLine("0. Завершить добавление вольеров");
    string inputAviary = Console.ReadLine();
    switch (inputAviary)
    {
        case "1": // 1. Водный
            aviaryCreator = new AquaAviaryCreator();
            break;
        case "2": // 2. Сухопутный
            aviaryCreator = new LandAviaryCreator();
            break;
        case "0": // 0. Завершить добавление вольеров
            exit = true;
            break;
    }
    if (exit) break;
    
    Console.Write("Введите количество животных:");
    int count = Convert.ToInt32(Console.ReadLine());
    Aviary aviary = aviaryCreator.Create(count);
    aviaries.Add(aviary);

    do
    {
        Console.WriteLine("Выберите животное для добавления в вольер:");
        Console.WriteLine("1. Рыба");
        Console.WriteLine("2. Птица");
        Console.WriteLine("3. Млекопитающее");
        Console.WriteLine("4. Насекомое");
        Console.WriteLine("0. Завершить добавление животных");
        
        string inputAnimal = Console.ReadLine();
        switch (inputAnimal)
        {
            case "1": // 1. Рыба
                animalCreator = new FishCreator();
                break;
            case "2": // 2. Птица
                animalCreator = new BirdCreator();
                break;
            case "3": // 3. Млекопитающее
                animalCreator = new MammaliaCreator();
                break;
            case "4": // 4. Насекомое
                animalCreator = new InsectCreator();
                break;
            case "0": // 0. Завершить добавление животных
                exit = true;
                break;
        }
        if (exit) break;
        
        Console.Write("Введите вид животного:");
        string kind = Console.ReadLine();
        Animal animal = animalCreator.Create(kind);
        bool result = aviary.AddAnimal(animal);

        Console.WriteLine(result ? "Животное успешно добавлено" : "Ошибка добавления животного");
    } while (true);
    
} while (true);

foreach (Aviary aviary in aviaries)
{
    Console.WriteLine($"{aviary.GetType().Name}: total animals - {aviary.totalCount}");
    foreach (Animal animal in aviary.animals)
    {
        Console.WriteLine($"{animal.GetType().Name} -> {animal.kind}");
    }
}
using ZooParkApp.loggers;
using ZooParkApp.ui;
using ZooParkApp.zoo;

var count = ConsoleHelper.InputInt("Введите количество вольеров зоопарка:");
var zoo = new Zoo()
{
    TotalAviaries = count,
    Logger = new LogToFile("zoo.log")
};

while (true)
{
    ConsoleHelper.SleepAndClear();
    
    ConsoleHelper.PrintLine("Режим работы:");
    ConsoleHelper.PrintLine("1. Добавление вольеров");
    ConsoleHelper.PrintLine("2. Добавление животных");
    ConsoleHelper.PrintLine("3. Просмотр всех животных");
    ConsoleHelper.PrintLine("4. Просмотр всех вольеров");
    ConsoleHelper.PrintLine("0. Выход");
    var mode = ConsoleHelper.InputString("Введите номер режима:");
    switch (mode)
    {
        case "0":
            return;
        case "1":
            ZooHelper.AddAviaries(zoo);
            break;
        case "2":
            ZooHelper.AddAnimals(zoo);
            break;
        case "3":
            ZooHelper.PrintAnimals(zoo.Animals);
            break;
        case "4":
            ZooHelper.PrintAviaries(zoo.Aviaries);
            break;
    }
}
using ZooParkApp.creators.animals;
using ZooParkApp.creators.aviaries;
using ZooParkApp.loggers;
using ZooParkApp.models.animals;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.zoo;

public class Zoo
{
    public int TotalAviaries { get; init; }

    public ICollection<Animal> Animals { get; init; } = new List<Animal>();
    public ICollection<Aviary> Aviaries { get; init; } = new List<Aviary>();

    public ILogger? Logger { get; set; }

    public bool AddAnimal(string kind, AnimalType animalType, Aviary aviary)
    {
        AnimalCreator animalCreator = animalType switch
        {
            AnimalType.Bird => new BirdCreator { Kind = kind, Logger = this.Logger },
            AnimalType.Fish => new FishCreator { Kind = kind, Logger = this.Logger },
            AnimalType.Insect => new InsectCreator { Kind = kind, Logger = this.Logger },
            AnimalType.Mammalia => new MammaliaCreator { Kind = kind, Logger = this.Logger }
        };

        var animal = animalCreator.Create();

        if (!Aviaries.Contains(aviary)) return false;
        if (!aviary.AddAnimal(animal)) return false;

        Animals.Add(animal);
        return true;
    }

    public bool AddAviary(string name, int count, AviaryType aviaryType)
    {
        AviaryCreator aviaryCreator = aviaryType switch
        {
            AviaryType.Aqua => new AquaAviaryCreator { Name = name, Count = count, Logger = this.Logger},
            AviaryType.Land => new LandAviaryCreator { Name = name, Count = count, Logger = this.Logger }
        };

        var aviary = aviaryCreator.Create();
        if (Aviaries.Count >= TotalAviaries) return false;
        Aviaries.Add(aviary);
        return true;
    }
}
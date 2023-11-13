using ZooParkApp.creators;
using ZooParkApp.creators.animals;
using ZooParkApp.creators.aviaries;
using ZooParkApp.models.animals;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.zoo;

public class Zoo
{
    public readonly int TotalAviaries;
    
    public readonly ICollection<Animal> Animals;
    public readonly ICollection<Aviary> Aviaries;

    public Zoo(int totalAviaries)
    {
        this.TotalAviaries = this.TotalAviaries;
        
        Animals = new List<Animal>();
        Aviaries = new List<Aviary>();
    }
    
    public bool AddAnimal(string kind, AnimalType animalType, Aviary aviary)
    {
        AnimalCreator animalCreator = animalType switch
        {
            AnimalType.Bird => new BirdCreator(kind),
            AnimalType.Fish => new FishCreator(kind),
            AnimalType.Insect => new InsectCreator(kind),
            AnimalType.Mammalia => new MammaliaCreator(kind)
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
            AviaryType.Aqua => new AquaAviaryCreator(name, count),
            AviaryType.Land => new LandAviaryCreator(name, count)
        };

        var aviary = aviaryCreator.Create();
        if (Aviaries.Count >= TotalAviaries) return false;
        Aviaries.Add(aviary);
        return true;
    }
}
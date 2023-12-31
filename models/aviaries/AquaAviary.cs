﻿using ZooParkApp.models.animals;
using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.aviaries;

public class AquaAviary : Aviary
{
    public override bool AddAnimal(Animal animal)
    {
        if (!IsFree) return false;

        if (animal is not ISwimming) return false;

        Animals.Add(animal);
        return true;
    }
}
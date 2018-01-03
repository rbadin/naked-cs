using System;

abstract class Animal
{
    public abstract int LegCount();
}

class Mammal : Animal
{
    public bool fur;
    public string name;
    public Mammal() { }

    public override int LegCount()
    {
        return 4;
    }

    public void Print()
    {
        Console.WriteLine("A {0} has {1} legs.", name, LegCount());
        if (fur)
            Console.WriteLine("It has fur.");
        else
            Console.WriteLine("It has no fur.");
    }
}

class Dolphin : Mammal
{
    public Dolphin()
    {
        fur = false;
        name = "Dolphin";
    }
    public override int LegCount()
    {
        return 0;
    }
}

class Wombat : Mammal
{
    public Wombat()
    {
        fur = true;
        name = "Wombat";
    }
}

class CreateAnimals
{
    static void Main()
    {
        Wombat w = new Wombat();
        w.Print();

        Dolphin d = new Dolphin();
        d.Print();
    }
}
Console.WriteLine("Name dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Dogg");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("BBoy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.Wag();


class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name) 
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    { 
        get { return _levelOfHapiness; } 
    }

    public void Rename(string newName) 
    { 
        _name = newName;
        Console.WriteLine($"Dog new name is: {newName}.");
    }

    public void Bark() 
    {
        Console.WriteLine("Boof!");
        _levelOfHapiness++;
    }

    public void Wag()
    {
        Console.WriteLine("Epic");
    }
}

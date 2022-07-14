interface IAnimal
{
    void Drink();
}

interface ICarnivorous
{
    void Eat();
}

interface IReptile : IAnimal, ICarnivorous
{
    void Habitat();
}

class Crocodile : IReptile
{
    public void Drink()
    {
        Console.WriteLine("Uong nuoc");
    }
    public void Habitat()
    {
        Console.WriteLine("bla bla");
    }
    public void Eat()
    {
        Console.WriteLine("An");
    }
    
    static void Main(string[] args)
    {
        Crocodile crocodile = new Crocodile();
        Console.WriteLine(crocodile.GetType().Name);
        crocodile.Drink();
        crocodile.Eat();
        crocodile.Habitat();

    }
}
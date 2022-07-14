abstract class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product(int Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }
    public abstract double computeTax();
}


class Book : Product
{
    public Book(int id, string name, double price) : base(id, name, price)
    {

    }
    public override double computeTax()
    {
        return this.Price * 5/100;
    }
}

class Phone : Product
{
    public Phone(int id, string name, double price) : base(id, name, price)
    {

    }
    public override double computeTax()
    {
        return this.Price * 10/100;
    }
}



// Class test
class Program
{
    static void Main(string[] args)
    {
        // Array Product (3 book, 2 phone)
        Product[] listProduct = new Product[5];
        listProduct[0] = new Book(1, "Dac nhan tam", 300);
        listProduct[1] = new Book(2, "Cha giau cha ngheo", 450);
        listProduct[2] = new Book(3, "So Do", 500);
        listProduct[3] = new Phone(4, "Iphone 10", 2220);
        listProduct[4] = new Phone(5, "Iphone 11", 1990);

        // Total Tax
        double TaxBook = 0;
        double TaxPhone = 0;
        foreach (var product in listProduct)
        {
            if (product.GetType().ToString()=="Book")
            {
                TaxBook+=product.computeTax();
            }else if (product.GetType().ToString()=="Phone")
            {
                TaxPhone+=product.computeTax(); 
            }
        }
        Console.WriteLine("Tax Book : {0}",TaxBook);
        Console.WriteLine("Tax Phone : {0}", TaxPhone);
        Console.WriteLine("Tax Total : {0}",TaxBook+TaxPhone);
        
    }
}
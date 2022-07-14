abstract class Product
{
    string id;
    string name;
    double price;
    public string ProductID
    {
        get
        {
            return id;
        }
        set { id = value; }
    }
    public string ProductName
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Product(string id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
    public abstract double computeTax();
}

public class Book : Product
{
    public Book(string id, string name, double price) : base(id, name, price)
    {
    }
    public override double computeTax()
    {
        return Price*5/100;
    }

}

public class Phone : Product
{
    public Phone(string id, string name, double price) : base(id, name, price)
    {
    }
    public override double computeTax()
    {
        return Price*10/100;
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        Product[] listProduct = new Product[5];
        Book book1 = new Book("001", "Dac nhan tam", 20);
        Book book2 = new Book("002", "Cha giau cha ngheo", 15);
        Book book3 = new Book("003", "So do", 12);
        Phone phone1 = new Phone("004", "Iphone 13", 200);
        Phone phone2 = new Phone("005", "Iphone 12", 150);
        Phone phone3 = new Phone("006", "Iphone 11", 120);
        foreach (Product product in listProduct)
        {
            Console.WriteLine("{0} : tax = {1}",product.ProductName,product.computeTax());
        }
    }
}


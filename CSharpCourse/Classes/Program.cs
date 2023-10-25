// Classlara Giriş

using Classes;

// Classlar İçinde Property Tanımlamak
Customer customer = new Customer();

customer.City = "Ankara";
customer.Id = 1;    
customer.FirstName = "Onur";
customer.LastName = "Baha";

Customer customer2 = new Customer
{
    Id = 2,
    City = "İstanbul",
    FirstName = "Onur",
    LastName = "Baha",
};

Console.WriteLine(customer2.FirstName);



CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();

productManager.Add();
productManager.Update();

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}

class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }
    public void Update()
    {
        Console.WriteLine("Product Updated!");
    }
}


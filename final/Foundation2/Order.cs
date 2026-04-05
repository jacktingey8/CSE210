
class Order
{
    private List<Product> _purchasedProducts= new List<Product>();
    private Customer _customer;

    public Order(Customer customer,List<Product> products)
    {
        _purchasedProducts=products;
        _customer=customer;
    }
    private double total = 0;
    
    public void GetPackingLabel()
    {   
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("PACKING LABEL");
        foreach(Product product in _purchasedProducts)
        {
            Console.WriteLine($"Name:{product.GetName()} ID:{product.GetID()}");
        }
        Console.WriteLine("----------------------------------------------------------------------");
    }
    public void GetShippingLabel()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine($"Name:{_customer.GetName()}");
        Console.WriteLine($"Address:{_customer.GetAddress()}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    public double GetOrderPrice()
    {
        
        foreach(Product product in _purchasedProducts)
        {
            total=total+product.GetPrice();
        }
        if (_customer.CheckCountry() == true){total=total+5;}
        else{total=total+35;}
        return total;
    }
}
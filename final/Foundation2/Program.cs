using System;

class Program
{

    static void GetOrderInfo(Order order)
    {
        order.GetPackingLabel();
        order.GetShippingLabel();
        Console.WriteLine($" TOTAL PRICE:{order.GetOrderPrice()}");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("19 Case Lane","Amarillo","Texas", "USA");
        Customer customer1 = new Customer("Maddison", address1);
        Product product11 = new Product("Wig",1,39.99,1);
        Product product12 = new Product("Comb",2,5.59,2);
        List<Product> cart1 = new List<Product>{product11,product12};
        Order order1 = new Order(customer1,cart1);
        GetOrderInfo(order1);
        

        Address address2 = new Address("143 Neb Street","The Valley","GaggleLand", "Gerpan");
        Customer customer2 = new Customer("Paul", address2);
        Product product21 = new Product("Can of Soup",3,2.99,5);
        Product product22 = new Product("Can Opener",4,6.00,2);
        List<Product> cart2 = new List<Product>{product21,product22};
        Order order2 = new Order(customer2,cart2);
        GetOrderInfo(order2);

    }
}
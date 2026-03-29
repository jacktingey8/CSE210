using System.Globalization;

class Product
{
    private string _name;
    private int _productID;
    private double _price;

    public string GetName(){return _name;}
    public int GetID(){return _productID;}
    private int _quantity;  

    public Product(string name, int id, double price,int quantity )
    {_name=name; _productID=id;_price=price;_quantity=quantity;}
    public double GetPrice(){return _price * _quantity;}
}
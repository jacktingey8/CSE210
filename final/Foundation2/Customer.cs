class Customer
{
    private string _name;
    private Address _address;

    public string GetAddress(){return _address.GetCompiledAddress();}
    public string GetName(){return _name;}

    public Customer(string name, Address address){_name=name;_address=address;}

     public bool CheckCountry()
    {
        if (_address.GetCountry() == "USA"){return true;}
        else{return false;}
    }
}
using System.Dynamic;
using System.Runtime.InteropServices;

class Address
{
    private string _streetAddress;
    private string _city;
    
    private string _state;

    private string _country;

    public string GetCountry(){return _country;}


    public Address(string street, string city, string state, string country)
    {_streetAddress=street; _city = city; _state=state; _country=country;}

public bool CheckCountry()
    {
        if (_country == "USA"){return true;}
        else{return false;}
    }


    public string GetCompiledAddress(){return $"{_streetAddress} - {_city} - {_state} - {_country}";}
}
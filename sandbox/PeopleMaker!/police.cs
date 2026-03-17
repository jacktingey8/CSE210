class Police : Person
{
    private string _weapons;

public Police(string weapon, string first, string last, int age, int weight): base(first,last,age, weight)
    {
        _weapons=weapon;
    }
    
public string GetPoliceInfo(){return $"Weapon: {_weapons}, {GetPersonInfo()}";}



}
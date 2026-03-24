class Police : Person
{
    private string _weapons;

public Police(string weapon, string first, string last, int age, int weight): base(first,last,age, weight)
    {
        _weapons=weapon;
    }
    
public override string GetPersonInfo(){return $"Weapon: {_weapons}, {base.GetPersonInfo()}";}

    public override double GetSalary()
    {
        return 1111111;
    }


}
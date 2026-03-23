class Person
{
    
    private string _firstname;
    private string _lastname;

    private int _age;

    private int _weight;

    public Person(string first, string last, int age, int weight)
    {
        _firstname=first;
        _lastname=last;
        SetAge(age);
        SetWeight(weight);
    }

    public virtual string GetPersonInfo(){return $"{_firstname} {_lastname}. age:{_age}. weight:{_weight}";}

    public int GetAge(){return _age;}
    public int GetWeight(){return _weight;}

    public void SetWeight(int weight){if (weight <4 || weight>500){Console.WriteLine("invalid weight");}
    else {_weight=weight;}}

    public void SetAge (int age){if (age <0 || age>100){Console.WriteLine("invalid Age");}
    else {_age=age;}}





}
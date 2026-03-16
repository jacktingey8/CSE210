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
        _age=age;
        _weight=weight;
    }

    public string GetPersonInfo(){return $"{_firstname} {_lastname}. age:{_age}. weight:{_weight}";}


}
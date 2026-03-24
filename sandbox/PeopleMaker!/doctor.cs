class Doctor : Person
{
private string _tools;

public Doctor(string tools, string first, string last, int age, int weight): base(first,last,age, weight)
    {
        _tools=tools;
    }
    
public override string GetPersonInfo(){return $"Tools: {_tools}, {base.GetPersonInfo()}";}

// public string GetDoctorInfo(){return $"Tools: {_tools}, {GetPersonInfo()}";}

  public override double GetSalary()
    {
        return 238129716;
    }


















}
class Doctor : Person
{
private string _tools;

public Doctor(string tools, string first, string last, int age, int weight): base(first,last,age, weight)
    {
        _tools=tools;
    }
    
public string GetDoctorInfo(){return $"Tools: {_tools}, {GetPersonInfo()}";}




















}
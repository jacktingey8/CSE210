using System.Dynamic;
using System.Runtime.InteropServices.Swift;

abstract class Goal
{
    
protected string _name;

protected  string _description;

public int _bonusPoints;
public  int _points;

protected string _goalType;

public int _completion;

protected int _progress;
protected string _goalDone;

public Goal()
    {
       _name = "";
       _description = "";
       _points = 0;
       _goalType = ""; 
       _completion= 0;
       _goalDone = " ";
       _bonusPoints=0;
    }

abstract protected void SetGoalType();

public void SetName()
    {
    Console.WriteLine("Name Your Goal:");
    _name = Console.ReadLine();
    } 
public void SetDescription()
    {
     Console.WriteLine("Describe Your Goal:");
    _description = Console.ReadLine();   
    } 

virtual public void SetPoints()
    {
    Console.WriteLine("Enter Point Value:");
    _points=int.Parse(Console.ReadLine());
    } 


public void ExecuteGoal()
    {
        SetGoal();
        Console.WriteLine(GetCompiledGoal());
    }


 virtual public string GetSaveFormatGoal(int totalscore){return $"{this._name}#{this._description}#{this._completion}#{this._points}#{this._goalType}#{this._progress}#{totalscore}";}

virtual public int UnravelGoal(List<string> thelist, Goal goal)
    {
    goal._name =thelist[0];
    goal._description =thelist[1];
    goal._completion =int.Parse(thelist[2]);
    goal._points =int.Parse(thelist[3]);
    goal._goalType  =thelist[4];
    goal._progress =int.Parse(thelist[5]); 
    return int.Parse(thelist[6]); 
    }
virtual protected void SetGoal()
    {
        SetGoalType();
        SetName();
        SetDescription();
    }

virtual public string GetCompiledGoal()
    {
    if(_completion>=_progress){_goalDone="X";}
    return $"[{_goalDone}] {_name}: {_description} | Point Value: {_points} - {_goalType}";
    }




}
class EternalGoal : Goal
{
    
protected override void SetGoalType()
    {
        _goalType= "EternalGoal";
    }

protected override void SetGoal()
    {
        base.SetGoal();
        Console.WriteLine("Points Per Completion:");
        _points=int.Parse(Console.ReadLine());}

public override string GetCompiledGoal()
    {return $"[{_completion}] {_name}: {_description} | Point Per complete: {_points} - {_goalType}";}
    



}
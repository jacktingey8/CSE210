class CheckListGoal : Goal
{
    protected override void SetGoalType()
    {
        _goalType= "CheckListGoal";
    }


public CheckListGoal() :base(){}

    protected override void SetGoal()
    {
        base.SetGoal();
        Console.WriteLine("How many times do you have to complete your goal?:");
        _progress=int.Parse(Console.ReadLine());
        Console.WriteLine("How many points per goal completion?:");
        _points=int.Parse(Console.ReadLine());
        Console.WriteLine("How many points for final completion?:");
        _bonusPoints=int.Parse(Console.ReadLine());
        
    }

    public override string GetCompiledGoal()
    {
        if(_completion>=_progress){_goalDone="X";return $"[X] {_name}: {_description} | Point Per complete: {_points} Bonus final Completetion Points{_bonusPoints} - {_goalType}";}
    else{return $"[{_completion}/{_progress}] {_name}: {_description} | Point Per complete: {_points} Bonus final Completetion Points{_bonusPoints} - {_goalType}";}
    
    }

    public override string GetSaveFormatGoal(int totalscore)
    {

        return $"{this._name}#{this._description}#{this._completion}#{this._points}#{this._goalType}#{this._progress}#{totalscore}#{_bonusPoints}";
    }

    public override int UnravelGoal(List<string> thelist, Goal goal)
    {
        goal._bonusPoints= int.Parse(thelist[7]);
        return base.UnravelGoal(thelist, goal);
    }



}
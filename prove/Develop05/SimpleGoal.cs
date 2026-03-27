class SimpleGoal : Goal
{

    
    protected override void SetGoalType()
    {
        _goalType= "SimpleGoal";
    }
        public SimpleGoal() :base(){}


    protected override void SetGoal()
    {
        _progress=1;
        base.SetGoal();
        SetPoints();
        Console.WriteLine();
    }




}
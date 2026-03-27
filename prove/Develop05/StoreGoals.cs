using System.Net;

class StoreGoals
{

public List<Goal> _goalList = new List<Goal>();

public void DisplayGoals()
    {
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{_goalList.IndexOf(goal)+1}. {goal.GetCompiledGoal()}");
       ;
        }
    }

public List<List<string>> LoadGoals()
{
Console.WriteLine("Input File Name:");
string filename = Console.ReadLine();

string[] lines = System.IO.File.ReadAllLines(filename);
List<List<string>> translatedList= new List<List<string>>();

foreach (string line in lines)
{
    List<string> tempList = new List<string>();
    string[] parts = line.Split("#");
    tempList.AddRange(parts);
    translatedList.Add(tempList);
}
return translatedList;}

public void animation(int duration,bool seen)
    {
        if (seen==true){
        DateTime currentTime=DateTime.Now;
        DateTime endTime= currentTime.AddSeconds(duration);
        int sleepTime=150;
        string animationString= "-\\|/";
        int index = 0;
        Console.CursorVisible = false;
        while(DateTime.Now < endTime)
        {  
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
          Console.CursorVisible = true;}
    }


}
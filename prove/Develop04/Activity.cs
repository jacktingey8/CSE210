using System.Dynamic;

class Activity
{

protected string _name="temp";


protected int _duration;

protected string _description;

protected string _endMessage = "Activity Complete. Thank you for particapting in this mindfulness excercise ";


protected int GetRandomInt(int length)
    {
       Random random = new Random(); 
        return random.Next(1,length);
    }
 
public void Pause(int duration)
    {
        DateTime currentTime=DateTime.Now;
        DateTime endTime= currentTime.AddSeconds(duration);
        int sleepTime=150;
        string animationString= ".o0O0o";
        int index = 0;
        Console.CursorVisible = false;
        while(DateTime.Now < endTime)
        {  
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
          Console.CursorVisible = true;
    }

 protected void CountDown(int sleep)
    {   
        Console.CursorVisible=false;
        Console.Write("......");
        for (int i =0; i<6; i++){
        Thread.Sleep(sleep); 
        Console.Write("\b \b");
        }Console.CursorVisible=true;
    }




protected void ActivityIntro()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine("Please enter activity duration:");
        _duration = int.Parse(Console.ReadLine());
    } 





}
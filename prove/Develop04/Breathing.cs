
class Breathing : Activity
{
    
public Breathing(string name, string description)
    {
        _name=name;
        _description=description;
    }

 private void CountDown()
    {   
        Console.CursorVisible=false;
        Console.Write("...");
        Thread.Sleep(1000); 
        Console.Write("\b \b");
        Thread.Sleep(1000); 
        Console.Write("\b \b");
        Thread.Sleep(1000); 
        Console.Write("\b \b");
        Thread.Sleep(1000); 
        Console.Write("\b \b");
        Console.CursorVisible=true;
    }
public void BreathingActivity()
    {
    Pause(2);
    ActivityIntro();
    Pause(2);
        
    DateTime currentTime=DateTime.Now;
    DateTime endTime= currentTime.AddSeconds(_duration);
    Console.Clear();
    while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath In");
            CountDown(750);
            Console.WriteLine("Breath Out");
            CountDown(750); 
        }
        Console.Clear();
        Console.WriteLine(_endMessage);
        Console.ReadLine();





    }

    

}
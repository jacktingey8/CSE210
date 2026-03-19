class Listing : Activity
{
    
public Listing(string name, string description)
    {
        _name=name;
        _description=description;
    }

private List<string> prompts = new List<string> 
{"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"};


private int answerCount=0;

public void ListingActivity()
    {
    Pause(2);
    ActivityIntro();
    Pause(4);
    Console.Clear();
    Console.WriteLine(prompts[GetRandomInt(prompts.Count)]);
    Console.WriteLine("take a moment to ponder this question");
    CountDown(500);
    Console.WriteLine("Now enter as many answers as you can");
    DateTime currentTime=DateTime.Now;
    DateTime endTime= currentTime.AddSeconds(_duration);
    while (DateTime.Now < endTime)
        {
         Console.ReadLine();
         answerCount++;
        }
    Console.WriteLine($"Times up, You had {answerCount} answers");
    Console.WriteLine(_endMessage);
    Console.ReadLine();






    }


}
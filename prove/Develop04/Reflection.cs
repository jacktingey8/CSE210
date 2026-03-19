class Reflection : Activity
{
    
public Reflection(string name, string description)
    {
        _name=name;
        _description=description;
    }

private List<string> prompts = new List<string> 
{"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."};

private List<string> questions = new List<string> 
{"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"};

public void ReflectionActivity()
    {
    Pause(3);
    ActivityIntro();
    Pause(2);
    Console.Clear();
    Console.WriteLine(prompts[GetRandomInt(prompts.Count)]);
    Pause(2);
    Console.WriteLine("Now answer the following reflection questions");
    DateTime currentTime=DateTime.Now;
    DateTime endTime= currentTime.AddSeconds(_duration);
    while (DateTime.Now < endTime)
        {
        Console.WriteLine(questions[GetRandomInt(questions.Count)]);
        Console.ReadLine();
        Pause(1);
        }
    Console.WriteLine(_endMessage);
    Console.ReadLine();


    
    
    }


}
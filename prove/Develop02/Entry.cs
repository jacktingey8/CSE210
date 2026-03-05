public class Entry
{
    public static string[] _prompts= 
    ["What was the best part of your day?: ",
    "What was the worst part of your day?: ",
    "What is something interesting that happened to you today: ",
    "What have you learned from today: ",
    "What is something your proud of that happened today?: ",
    "What is something that you regret that happened today: "
    ];

    

    public DateTime _theCurrentTime = DateTime.Now;


    public string GetEntry()
    {
     Random randomGenerator = new Random();
     int randomIndex = randomGenerator.Next(_prompts.Length);
     string _selectedPrompt = _prompts[randomIndex];
    Console.WriteLine(_theCurrentTime);
    Console.WriteLine(_selectedPrompt);
    string _response = Console.ReadLine();

      return $"{_theCurrentTime} - {_selectedPrompt} {_response}";
    }
    

    







}
using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Choose a scripture to memorize");
        Console.WriteLine("[1] 1 Nephi 3:7");
        Console.WriteLine("[2] Moses 1:39");
        Console.WriteLine("[3] D&C 1:37-38");
        Console.WriteLine("[4] Matthew 11:28");

        

        int userInput = 0;
        bool choiceDone = false;
        while(!choiceDone){
        try
        {
         userInput=int.Parse(Console.ReadLine());   
        if (userInput>0 && userInput<5){choiceDone=true;}
        else {throw new Exception("");}
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("invalid input");
        }
        }

        
        Console.WriteLine("type 'q' when you want to quit");
        Console.WriteLine();
        Reference reference = new Reference(userInput);
        reference.ChooseScripture();
        Console.ReadLine();
        Console.Clear();
        
        Scriptures scripture = new Scriptures(reference.GetChosen());
        
       bool quit = false;

       while (!quit)
        {
            List<string> tempList=scripture.HideWord();
            Console.WriteLine(string.Join(" ",tempList));
            string keepGoing = Console.ReadLine();
            if(keepGoing == "q"){quit = true;}
            else {Console.Clear();}
        }
        Console.Clear();
        Console.WriteLine("Now write out the scripture");
        string userAnswer=Console.ReadLine();
        if(userAnswer == reference.GetScripture()){Console.WriteLine("Correct!");}
        else{Console.WriteLine("Incorrect.");}



    }


}
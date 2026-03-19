using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;
class Program
{

    static void Main(string[] args)
    {
        int MindfulCount=0;
        bool quit = false;
        while (!quit){
        
        if (MindfulCount == 3){Console.WriteLine("You have completed 3 Mindfulness Activities! We hope the activites brightened your day and helped you become more mindful.");Console.ReadLine();}
        else if (MindfulCount == 10){Console.WriteLine("You have completed 10 Mindful Activites! Thats probably enough for one day");}
        else if (MindfulCount == 50){Console.WriteLine("Please just stop, you've had enough!");}
        else if (MindfulCount == 100){Console.WriteLine("I'm cutting you off");Console.ReadLine();void Crash()=> Crash();}
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program - Please choose an activity");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflections Activity");
        Console.WriteLine("4.quit");
        
        int userChoice = int.Parse(Console.ReadLine());
        

        


        Console.Clear();

        
        if (userChoice == 1)
        {
        Breathing breathing = new Breathing("breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathing.BreathingActivity();
        MindfulCount ++;
        }
        else if (userChoice == 2)
        {
        Listing listing = new Listing("listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listing.ListingActivity();
        MindfulCount ++;
        }
        else if  (userChoice == 3)
        {
        Reflection reflection= new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflection.ReflectionActivity();
        MindfulCount ++;
        }
        else
        {
            quit = true;
        }
     
     
    ;}
}}
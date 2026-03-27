using System;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
Console.Clear();
int totalPoints =0;
bool quit= false;
bool seen50 = false;
StoreGoals storeGoals = new StoreGoals();
Console.WriteLine("Get to 50 points to unlock animations!");

while (!quit){
if (!seen50 && totalPoints>= 50)
            {
                Console.WriteLine("Congragulations on earning 50 points! You've unlocked animations!");
                seen50 = true;

            }
Console.WriteLine($"Total Score:{totalPoints}");
Console.WriteLine();
Console.WriteLine("1. Create New Goal");
Console.WriteLine("2. List Goals");
Console.WriteLine("3. Save Goals");
Console.WriteLine("4. Load Goals");
Console.WriteLine("5. Record Event");
Console.WriteLine("6. quit");
int userchoice =int.Parse(Console.ReadLine());


if (userchoice == 1)
            {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. CheckList Goal");
            Console.WriteLine("3. Eternal Goal");
            int goalChoice = int.Parse(Console.ReadLine());

            if(goalChoice == 1)
                {
                    Console.Clear();
                    SimpleGoal simpleGoal= new SimpleGoal();
                    simpleGoal.ExecuteGoal();
                    Console.ReadLine();
                    Console.Clear();
                    storeGoals._goalList.Add(simpleGoal);
                }

            else if(goalChoice == 2)
                {
                Console.Clear();
                CheckListGoal checkListGoal = new CheckListGoal();
                checkListGoal.ExecuteGoal();
                Console.ReadLine();
                Console.Clear();
                storeGoals._goalList.Add(checkListGoal);   
                }
            else if (goalChoice == 3)
                {
                Console.Clear();
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.ExecuteGoal();
                Console.ReadLine();
                Console.Clear();
                storeGoals._goalList.Add(eternalGoal); 

                }

            else {Console.WriteLine("Invalid Input");}
            storeGoals.animation(2,seen50);
            }

else if (userchoice == 2)
            {
            Console.Clear();
            storeGoals.DisplayGoals();
            Console.ReadLine();
            Console.Clear();
            storeGoals.animation(2,seen50);
            }

else if (userchoice == 3)
        {
        Console.WriteLine("Input File Name:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        foreach (Goal savedGoal in storeGoals._goalList){
        outputFile.WriteLine(savedGoal.GetSaveFormatGoal(totalPoints));
        }
        }
        Console.Clear();
        storeGoals.animation(2,seen50);
        }

else if (userchoice == 4)
            {
                List<List<string>> loadedGoals= storeGoals.LoadGoals();
                storeGoals._goalList.Clear();
                foreach(List<string> line in loadedGoals)
                {
                    if(line.Count<5){continue;}
                    if (line[4] == "SimpleGoal")
                    {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    totalPoints=simpleGoal.UnravelGoal(line, simpleGoal);
                    storeGoals._goalList.Add(simpleGoal);
                    }
                    if (line[4] == "CheckListGoal")
                    {
                    CheckListGoal checkListGoal = new CheckListGoal();
                    totalPoints=checkListGoal.UnravelGoal(line, checkListGoal);
                    storeGoals._goalList.Add(checkListGoal);
                    }
                    if (line[4] == "EternalGoal")
                    {
                    EternalGoal eternalGoal = new EternalGoal();
                    totalPoints=eternalGoal.UnravelGoal(line, eternalGoal);
                    storeGoals._goalList.Add(eternalGoal);
                    }
                }
                Console.Clear();
                storeGoals.animation(2,seen50);
            }

else if (userchoice == 5)
            {
            Console.Clear();
            storeGoals.DisplayGoals();
            Console.WriteLine("What goal have you completed:") ;
            int eventChoice = int.Parse(Console.ReadLine());
            Goal GoalCompleted = storeGoals._goalList[eventChoice-1];
            GoalCompleted._completion ++;
            totalPoints=GoalCompleted._points +totalPoints;
            Console.Clear();
            storeGoals.DisplayGoals();
            Console.ReadLine();
            Console.Clear();
            storeGoals.animation(2,seen50);
            }

else if (userchoice == 6)
            {
                quit = true;
            }

else {Console.WriteLine("inavlid input, try again");Console.ReadLine();}




}



}}
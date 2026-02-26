using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Greetings()
    {
        Console.WriteLine("Hello");
    }

    public static int AddNumbers(int n1,int n2)
    {
       return(n1+n2);
    }
    static void Main(string[] args)
    {

        Greetings();
        int total=AddNumbers(3,4);
        Console.WriteLine(total);
        // Console.Write("age:");
        // int age;
        // age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"You are {age}");

        // if (age <=100 && age != 19 && age !=0) Console.WriteLine("Ok");

        // else if (age == 19 || age==0) Console.WriteLine("Alright");
        
        // else Console.WriteLine("Yes");
        

        // for(int i=123456789;i>=0;i/=11)
        // {Console.Write(i);
        // Console.Write($":':,.;.,:':");}

        //bool done =false;

        // while(! done)
        // {
        // Console.Write("age: ");
        // int age = int.Parse(Console.ReadLine());
        // if (age >= 0 && age <=100)
        // { done = true;
        // Console.WriteLine("ok");}
        // else{Console.WriteLine("no");}
        
        // bool done=false;
        // do
        // {
        // Console.Write("age: ");
        // int age = int.Parse(Console.ReadLine());
        // if (age >= 0 && age <=100)
        // { done = true;
        // Console.WriteLine("ok");}
        // else{Console.WriteLine("no");}
        
        // } while(! done);


        // List<int> myData=new List<int>();
        // myData.Add(0);
        // myData.Add(1);
        // myData.Add(4);
        // myData.Add(3);

        // Console.WriteLine(myData.Count);
        // foreach(int i in myData)Console.WriteLine(i);

        // List<string> names = ["jack","jak","jaack"];
        // names.Add("jac");
        // foreach(string friend in names)Console.Write(friend);


    }
}
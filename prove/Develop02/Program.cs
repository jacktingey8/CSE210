using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       string[] menu =
        {
            "Welcome to the Journal Program",
            "1. Write a new Entry",
            "2. Display Journal Entry",
            "3. Save Journal",
            "4. Load Journal",
            "5. Quit",
            "6. Delete Journal"
            
        };
        void ProcessedMenu()
        {
    
            foreach (string line in menu){Console.WriteLine(line);}

        }

        List<string> entryList = new List<string>();
        
         ProcessedMenu();

        Journal journal = new Journal();

        bool finished = false;
        do{
        
        bool done=false; 
        int userChoice= int.Parse(Console.ReadLine());
        do
        {
       
        if(0< userChoice|| userChoice<7){done = true;}
        }while(!done);


        if(userChoice == 1)
        {   Entry entry = new Entry();
            string userEntry=entry.GetEntry();
            entryList.Add(userEntry);
            Console.WriteLine("Entry Saved");
        }
        if(userChoice == 2)
        {
            foreach(string Entries in entryList)
            Console.WriteLine(Entries);
        }
        if(userChoice == 3)
        {
            foreach(string entries in entryList)
            {journal.SaveToJournal(entries);}
            entryList.Clear();
            Console.WriteLine("Entries Saved To Journal");
        }
        if(userChoice == 4)
        {
            journal.LoadJournal();
        }
        if(userChoice == 5)
        {
            finished=true;
        }
        if (userChoice == 6)
        {journal.DeleteJournal();}
    


        } while(!finished);
    }
}
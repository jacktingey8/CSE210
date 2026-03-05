using System.IO;
public class Journal
{
    

public void SaveToJournal(string content )
{
    File.AppendAllText("MyJournal", content+Environment.NewLine);
}

public void LoadJournal()
    {
        foreach (string entry in File.ReadLines("MyJournal"))
        {
            Console.WriteLine(entry);
        }
    }


public void DeleteJournal()
    {
        Console.WriteLine("Type yes if you want to delete all journal Entries");
        if(Console.ReadLine()=="yes")
        {File.WriteAllText("MyJournal",$"Journal Restarted {DateTime.Now}" + Environment.NewLine);
        Console.WriteLine("Journal Deleted");}


        else {Console.WriteLine("Journal not deleted");}
        
    }

}
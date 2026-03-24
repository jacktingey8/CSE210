using System.ComponentModel;

class Program{

public static void ProcessPerson(Person theperson){Console.WriteLine(theperson.GetPersonInfo());}
public static void Main(string[] args){



Doctor doctor = new Doctor("scalpel", "jak","tingey", 53, 300);


Police police = new Police("gun", "jck","tingly",38,205);


List<Person> people = new List<Person>();
people.Add(doctor);
people.Add(police);


foreach (Person p in people){ProcessPerson(p);}

















}}
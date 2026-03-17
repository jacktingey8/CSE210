using System.ComponentModel;

class Program{

public static void ProcessPerson(Person theperson)
    {if (theperson is Police policeman){Console.WriteLine(policeman.GetPoliceInfo());}
    else if (theperson is Doctor thedoctor){Console.WriteLine(thedoctor.GetDoctorInfo());}
    else {Console.WriteLine(theperson.GetPersonInfo());}
    

    }



public static void Main(string[] args){;

Person person = new Person("jack","thingy", 19, 70);
Console.WriteLine(person.GetPersonInfo());

Doctor doctor = new Doctor("scalpel", "jak","tingey", 53, 300);
Console.WriteLine(doctor.GetDoctorInfo());

Police police = new Police("gun", "jck","tingly",38,205);
Console.WriteLine(police.GetPoliceInfo());


police.SetWeight(police.GetWeight()+15);
police.SetAge(police.GetAge()+1);
Console.WriteLine(police.GetPoliceInfo());


List<Person> people = new List<Person>();
people.Add(person);
people.Add(doctor);
people.Add(police);

foreach(Person p in people){ProcessPerson(p);}


















}}
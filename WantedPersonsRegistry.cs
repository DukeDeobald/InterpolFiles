namespace InterpolCardbox.InterpolNoticesApp.Models;

using System.Collections.Generic;
using System.Linq;

public class WantedPersonsRegistry
{
    private List<Suspect> wantedPersons = new List<Suspect>();

    public void AddWantedPerson(Suspect person)
    {
        wantedPersons.Add(person);
    }

    public void RemoveWantedPerson(int id)
    {
        var personToRemove = wantedPersons.FirstOrDefault(p => p.WantedPersonId == id);
        if (personToRemove != null)
            wantedPersons.Remove(personToRemove);
    }

    public Suspect FindWantedPersonById(int id)
    {
        return wantedPersons.FirstOrDefault(p => p.WantedPersonId == id);
    }

    public IEnumerable<Suspect> GetAllWantedPersons()
    {
        return wantedPersons;
    }
    public void PrintAllWantedPersons()
    {
        foreach (var person in wantedPersons)
        {
            Console.WriteLine($"Wanted Person ID: {person.WantedPersonId}");
            Console.WriteLine($"Name: {person.Forename} {person.LastName}");
            Console.WriteLine($"Date of Birth: {person.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Weight: {person.Weight} kg");
            Console.WriteLine($"Height: {person.Height} meters");
            Console.WriteLine($"Sex: {person.SexId}");
            Console.WriteLine($"Country of Birth ID: {person.CountryOfBirthId}");
            Console.WriteLine($"Nationality ID: {person.NationalityId}");
            Console.WriteLine($"Place of Birth: {person.PlaceOfBirth}");
            Console.WriteLine($"Distinguishing Marks: {person.DistinguishingMarks}");
            Console.WriteLine($"Hair Color: {person.HairColor}");
            Console.WriteLine($"Eye Color: {person.EyeColor}");
            Console.WriteLine("----------------------------------------");
        }
    }
        

}

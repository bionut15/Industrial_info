public class Person_1
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; private set; }
     public Person_1(string name, string surname, DateTime dateOfBirth)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
    }

    public int CalculateAge()
    {
        DateTime today = DateTime.Today;
        Age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-Age)) Age--;
        return Age;
    }
}


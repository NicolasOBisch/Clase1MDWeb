public class User
{  
    public string Name{get; set;}
    public string Surname{get; set;}

    public int YearBorn{get; set;}

    public User(){

    }
    


    public User( string name, string surname, int YB)
    {
        Name=name;
        Surname=surname;
        YearBorn=YB;
    }

    public string FullName()
    {
         return $"{Name} {Surname}";
    }

    public int FullDate(){

        return YearBorn;
    }
}

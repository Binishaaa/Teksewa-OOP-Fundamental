class Student(string name, DateTime dob, string college, string program) //parameterized constructor can be added in class
{
    public string name = name;
    public DateTime dob = dob ;
    public string college = college;
    public string program = program;

    //calculate age of a student in years and months e.g. 22 years and 2 months

    public string CalculateAge() // instance members: called through object 
    {
     var ageSpan = DateTime.Now - dob;   
     var year = ageSpan.Days / 365;
     var months = ageSpan.Days % 365 / 30; //% modulo- gives remainder
     return $"{year} Years and {months} Months";
    }

    //Get initials of a student e.g. Bishnu Singh Rawal => BR

    public string GetNameInitials()  
    {
        var nameParts = name.Split(" "); //split by space
        char firstInitials = nameParts[0][0];//[0] gives first name ; [0][0] gives first string of first name
        var lastInitials = nameParts[nameParts.Length-1][0]; //nameParts[nameParts.Length-1] gives last name and [0] gives initials
        //var lastInitals = namePartes[^1][0]; - using index operator for (length-1)
        return $"{firstInitials}{lastInitials}";
    }

    public string CapitalizeName()
    {
        return name.ToUpper();
    }
    // public string CapitalizeName() => name.ToUpper(); using arrow function :: used for one line method

    //print details of a student. Output format : BR is 22 Years and 2 Months old.

    public static string GetDetails(string initial, string age) =>  // initial and age are not instance member they are paramter so static can be used in this case
    $"{initial} is {age} old";
}
 


    
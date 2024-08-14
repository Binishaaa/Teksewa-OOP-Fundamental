using ABC;

internal class FileHandler
{
    public List<Person> ReadFile()
    {
        //print all text
        // string filePath = @"D:\Training\Teksewa-OOP-Fundamental\FileIO\Files\Employees.csv";
        // // @ to nullify escape character -verbating character
        // var fileContent = File.ReadAllText(filePath);
        // Console.WriteLine(fileContent);

        //Display name and dob of all people in employees.csv
        string filePath = @"D:\Training\Teksewa-OOP-Fundamental\FileIO\Files\Employees.csv";
        var fileContent = File.ReadAllText(filePath);
        var lines = fileContent.Split(["\n","\r"],StringSplitOptions.RemoveEmptyEntries);

        var employees = new List<Person>();
        foreach ( var line in lines.Skip(1))
        {   
            var data = line.Split(",",StringSplitOptions.RemoveEmptyEntries);
            var name = data[0];
            DateTime.TryParse(data [1],out DateTime d); //changing string dob to DateTime
            var dob = d;
            var nid = long.Parse(data [2]);

            var employee = new Person(name, dob, nid);
            employees.Add(employee);
        }

        foreach ( var emp in employees)
        {
            emp.PrintNameandDobDetails();
            Console.WriteLine();
        }  
        return employees;   
    }

    public void WriteFile()
    {
        string filePath = @"D:\Training\Teksewa-OOP-Fundamental\FileIO\Files\People.csv";
        File.WriteAllText(filePath, "This file contains people information\nThis file contains people information\n");
        Console.WriteLine("file is created");
    }

    //write in list
     public void WriteEmployeeToFile(List<Person> employees)
    {
        string filePath = @"D:\Training\Teksewa-OOP-Fundamental\FileIO\Files\Employees.txt";

        var employeesCollection = employees.Select(Person.ReturnNameandDobDetails); // function inside function
        File.WriteAllLines(filePath, employeesCollection);
    }
}

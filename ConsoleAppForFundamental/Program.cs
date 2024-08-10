
// Console.WriteLine("Hello, World!");

// Console.ReadLine();

// string userInput =  Console.ReadLine();
// Console.WriteLine($"Your entered  {userInput.Length} characters");

//Get user name and convert it to uppercase

// Console.WriteLine("Enter your name");
// string userName = Console.ReadLine();
// Console.WriteLine($"your name is {userName.ToUpper()}");

//Class::

//Person class::
// Person binisha = new(); //created object(Binisha) of class Person (instance of class Person)
// binisha.name = "Binisha Awale";
// binisha.nid = 3432484350988394582;
// binisha.dob = new DateTime(1998,04,13); 

// Console.WriteLine($"Name: {binisha.name}\n National Identifier: {binisha.nid}\n Date of Birth:{binisha.dob.ToString("dddd MMM dd, yyyy")}");

//using method to print multiple object:
// Person binisha = new(); //created object(Binisha) of class Person (instance of class Person)
// binisha.name = "Binisha Awale";
// binisha.nid = 3432484350988394582;
// binisha.dob = new DateTime(1998,04,13); 

// binisha.PrintDetails(); //PrintDetails prints all instance

// Person rabi = new(); //created object(rabi) of class Person (instance of class Person)
// rabi.name = "Rabi P";
// rabi.nid = 3432484090988394582;
// rabi.dob = new DateTime(1998,02,17);
// rabi.PrintDetails();


// Person A = new Person ("Awale", new DateTime(1998,3,2),34354353453454); // created object with argument
// A.PrintDetails(); 

//Page class
// Page P = new Page(12.57,45.32,"Hello World");
// P.Print();

//or asking user for input
// Console.WriteLine("Enter the height of the page in inches:");
// double height = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the width of page in inches");
// double width = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the title of the page");
// string title = Console.ReadLine();
// Page P = new Page(height,width,title);
// P.Print();

// class-Student.cs
Student binisha = new("Binisha P Awale", new DateTime(1998,04,13),"NCIT", "Computer Engineering");
var x = binisha.CalculateAge();
Console.WriteLine(x);

var y = binisha.GetNameInitials();
Console.WriteLine(y);

// Console.WriteLine(binisha.CapitalizeName());

var Output = Student.GetDetails(y,x); // here object(binisha.GetDetails) is not necessary since used they are not object members
Console.WriteLine(Output);

// var Output = Student.GetDetails(age:x, initial :y); //named parameter
// Console.WriteLine(Output); 

// Student binisha = new("Binisha P Awale", new DateTime(1998,04,13),"NCIT", "Computer Engineering");
// (string AgeString, int AgeDays) = binisha.CalculateAge();
// var y = binisha.GetNameInitials();


// var Output = Student.GetDetails(age: AgeString, initial:y);
// var Output1 = Student.GetDetails(age : AgeString, initial:y, ageDay: AgeDays);
// Console.WriteLine(Output);
// Console.WriteLine(Output1);




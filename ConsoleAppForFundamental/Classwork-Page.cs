//Create a class called "Page" - page of web
//with fields height(inch), width(inch) and title
//"Page" should have parameterized constructor which assigns each fields
//Create a method that prints height and width of that page in pixels
//Create instance of this class and display details in console

class Page
{
    public Page(double h, double w, string t)
    {
        height = h;
        width = w;
        title= t;

    }
    public double height; 
    public double width;
    public string title;

    public void Print()
    {
        Console.WriteLine($"Height:{this.height*96} pixel\n Width:{this.width*96} pixel\n title:{this.title}");
    }


}
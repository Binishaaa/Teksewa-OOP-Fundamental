class PersonBMI
{

    public PersonBMI(string n, double h, double w)
    {
        name = n;
        height = h;
        weight = w;
    }
    public string name;
    public double height;
    public double weight;
   
    double CalculateBMI(double height, double weight)
    {
        double bmi = weight/Math.Pow((height*0.3048),2);
        return Math.Round(bmi,2);
    }
public void PrintBMIDetails()
{
    Console.WriteLine($"BMI of {this.name} having height {this.height} feet and weight {this.weight}kg is {CalculateBMI(this.height,this.weight)}");
}
}
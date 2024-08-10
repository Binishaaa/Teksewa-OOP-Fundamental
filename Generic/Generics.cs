//Generics: if required different data type in different method, Generics is used.
//method Generics
// public class Generics
// {
//     public void PrintDetails<T, U>(T x, U y)
//     {
//         Console.WriteLine($"Value of X: {x} and Value of Y: {y}");
//     }

// }
//Class Generic
public class Generics <T, U>
{
    public void PrintDetails(T x, U y)
    {
        Console.WriteLine($"Value of X: {x} and Value of Y: {y}");
    }

}
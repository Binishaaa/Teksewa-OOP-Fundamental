internal class ParallelAndAsync
{
    //Parallel Programming : Ability to compute our tasks simultaneoulsy in multiple CPU cores
    // .NET has TPL -  Task Parallel Library
    //Task, Task<> class

    int[] numbers = [234, 3233, 3243, 433, 54545656, 32433];
    public void ComputeSequential()
    {
         Console.WriteLine("computing in sequence");
        foreach ( int number in numbers)
            ComputeIfPrime(number);

    }
    public void ComputeParallel()
    {   
        Console.WriteLine("computing in parallel");
        Parallel.ForEach(numbers, x => 
            ComputeIfPrime(x));
    }

    private void ComputeIfPrime(int num)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Computing {num}... Done");
    }

    //Asynchronous Programming : side effect of parallel
    //doing things in background in non-blocking way
    //boiling water for tea - working in other field as well

    //applies on independent task and taking some more time

    //async and await
    public async Task DoTask1()
    {
        await Task.Delay(1000);
    }

    public async Task<string> DoTask2()
    {
        HttpClient client = new HttpClient();
        var homePageContent = await client.GetStringAsync("https://appsoft.edu.np/");
        return homePageContent;
    }
}
ParallelAndAsync parallel = new ParallelAndAsync();
// parallel.ComputeSequential();
// parallel.ComputeParallel();

var output2 = await parallel.DoTask2();
Console.WriteLine(output2);

namespace BenchmarkTemplate;

[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public void MethodA()
    {
        
    }
    
    [Benchmark]
    public void MethodB()
    {
        
    }
}
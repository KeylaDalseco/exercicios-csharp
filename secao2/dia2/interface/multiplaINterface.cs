public interface IStartable2
{
    void Start();
}

public interface IStoppable
{
    void Stop();
}

public class Engine2 : IStartable2, IStoppable // mais de uma interface
{
    public void Start() => Console.WriteLine("Engine started!");
    public void Stop() => Console.WriteLine("Engine stopped!");
}
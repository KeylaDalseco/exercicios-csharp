interface IGreeter
{
    void SayGreeting(string greeting);
}

// interface com metodo padrão
public interface IStartable
{
    void Start()
    {
        Console.WriteLine("Item started");
    }
}


public class Engine : IStartable
{
}
// IStartable engine = new Engine(); // devemos tipar com  a interface
// engine.Start();
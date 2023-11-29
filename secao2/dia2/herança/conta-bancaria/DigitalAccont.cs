public class DigitalAccount : Account
{
    public OperatingSystem AccountCreationOS { get; }
    public DateTime AccountCreationDate { get; } = DateTime.Now;

    public DigitalAccount(string owner, OperatingSystem OS) : base(owner) // passando o parametro da superclasse
    {
        AccountCreationOS = OS;
    }

    public override void Deposit(decimal amount) // override modifica metodo da superclasse
    {
        _balance += amount;
        Console.WriteLine($"New balance is {_balance}");
    }
}
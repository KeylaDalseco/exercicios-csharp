public class Account
{
    public decimal _balance;

    public string Owner { get; set; }
    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance can't be negative!");
            _balance = value;
        }
    }

    public Account(string owner)
    {
        Owner = owner;
    }

// É USADO VIRTUAL OU ABSTRACT PARA PERMITIR DE O METODO SEJA ALTERADO EM OUTRA CLASSE
    public virtual void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) => Balance -= amount;
}
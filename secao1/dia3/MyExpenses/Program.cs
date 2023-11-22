class Program
{
    static void Main(string[] args)
      {
        int[] expensesCost;
        Console.WriteLine("Entre com o número de despesas: ");
        int numberOfExpenses = getNumberOfExpenses();

        expensesCost = new int[numberOfExpenses];

        for (int i=0; i < numberOfExpenses; i++)
        {
          expensesCost[i] = getExpenseCostFromUser();
        }

        int totalExpenses = 0;

        for (int i = 0; i < numberOfExpenses; i++)
        {
          totalExpenses += expensesCost[i];
        }

        Console.WriteLine("O total das despesas é: " + totalExpenses);
      }
        public static int getNumberOfExpenses()
    {
        Console.WriteLine("Entre com o número de despesas: ");
        string entry = Console.ReadLine();
        int convertInt = Convert.ToInt32(entry);
        return convertInt;
    }

    public static int getExpenseCostFromUser()
    {
        Console.WriteLine("Entre com a despesa: ");
        string entry = Console.ReadLine();
        int convertInt = Convert.ToInt32(entry);
    }
}
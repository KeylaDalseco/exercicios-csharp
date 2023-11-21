// CAST IMPLÍCITO -> não declaramos no código que essa transformação deve ocorrer
public class Program
{
    public static void Main()
    {
        int intResult = 5/2; // é retornado 2 pois implicitamente o compilador ignora as casas decimais

        Console.WriteLine(intResult);
    }
}

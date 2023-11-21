// CAST EXPLICITO -> nesse caso devemos indicar a ação
public class Program2
{
    public static void Main2()
    {
        long someLongNumber = 516144066604654;
        int intNumber = (int) someLongNumber; // funciona e tem perda de dados.

        Console.WriteLine(intNumber);
    }
}

public class Program3
{
    public static void Main3()
    {
        long someLongNumber = 42;
        int intNumber = Convert.ToInt32(someLongNumber); // vai avisar que o long não cabe no ont
        Console.WriteLine(intNumber);
    }
}


public class ConvertString
{
    public static void Main4()
    {
        string someString = "42";
        int convertInt = Convert.ToInt32(someString); // converte a string em inteiro
        Console.WriteLine(convertInt);
    }
}
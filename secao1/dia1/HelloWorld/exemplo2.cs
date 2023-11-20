namespace namespaceExample;

//Criando um enum
internal enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};

internal class Program
{
    public static void Main()
    {
        //Utilizando um enum
        CardinalPoints direction = CardinalPoints.Norte;
        Console.WriteLine("Ponto Cardeal: " + direction);
    }
}


//Como declarar uma constante
// const string url = "https://www.betrybe.com/";
// const int numberOfAttemptsAllowed = 5;

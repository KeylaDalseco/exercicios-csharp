// Requisito 1: Imprima uma mensagem de saudação
// Requisito 2: Receba a entrada da pessoa usuária e converta para Int
// Requisito 3: Gere um número aleatório
// Requisito 4: Verifique a resposta da jogada

public class Program
{
    public static void Main()
    {
        string greeting = Greet();
        Console.WriteLine(greeting);
    }

    public static string Greet()
    {
        string GreetMsg = "";
        GreetMsg += "---Bem-vindo ao Guessing Game--- \n";
        GreetMsg += " Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
        return GreetMsg;
    }

    public string ChooseNumber(string userEntry)
    {
    bool canConvert = Int32.TryParse(userEntry, out userValue);
    if (!canConvert)
    {
        return "Entrada inválida! Não é um número.";
    }

    if(userValue > 100 || userValue < -100)
    {
        userValue = 0;
        return "Entrada inválida! Valor não está no range.";
    }
    return "Número escolhido!";
    }

    public string RandomNumber()
    {
        randomValue = random.GetInt(-100, 100);
        return "A máquina escolheu um número de -100 à 100!";
    }

    public string AnalyzePlay()
    {
    if(userValue > randomValue)
    {
        return "Tente um número MENOR";
    }
    else if(userValue < randomValue)
    {
        return "Tente um número MAIOR";
    }
    else
    {
        gameOver = true;
        return "ACERTOU!";
    }
    }
}
public static string IdentifyPolygon(int sideCount)
{
    var name = string.Empty; // ou ""
    switch (sideCount)
    {
        case < 3:
            name = "Não é um polígono";
            break;
        case 3:
            name = "Triângulo";
            break;
        case 4:
            name = "Quadrado";
            break;
        case 5:
            name = "Pentágono";
            break;
        default:
            name = "Polígono não identificado";
            break;
    }
    return name;
}

// exemplo
switch (number) // será analisado o valor da variável number.
{
    case > 0:
        Console.WriteLine("maior que 0");
        break;
    case 0:
        Console.WriteLine("igual a zero");
        break;
    default:
        Console.WriteLine("menor que zero");
        break;
}

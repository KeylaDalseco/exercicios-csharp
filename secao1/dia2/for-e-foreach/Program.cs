// exemplo for

for (int count = 0; count < 3; count++)
{
    Console.WriteLine("numero: " + count);
}

// exemplo foreach:

foreach (tipo elemento in coleção)
{
    //comandos;
}
// formas de iniciar arrays:
// ou  int[] numbers = { 1, 2, 3, 4, 5 };
// ou  int[] numbers = new int[5];
string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (var name in names)
{
    Console.WriteLine(name);
}


// O laço foreach percorrerá todos os itens do array verificando se o valor do mesmo é maior que três. Se for, fará uso da instrução continue para saltar a iteração do laço. Dessa forma a variável count só será incrementada para votos válidos.

int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
var count = 0;
foreach (var vote in votes)
{
    if (vote > 3)
        continue;
    count++;
}
Console.WriteLine(count + ' votos válidos');
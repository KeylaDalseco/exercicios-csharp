// exemplo 1 - if
if(age > 15)
{
    Console.WriteLine("idade maior que quinze");
}

// exemplo 2 -  if e else
int month = 1
if(month == 1)
{
    Console.WriteLine("mês janeiro");
}
else
{
    Console.WriteLine("mês diferente de janeiro");
}


// exemplo 3 -  efeito cascata

if(number > 0)
{
    Console.WriteLine("maior que zero");
}
else
{
    if(number < 0)
    {
        Console.WriteLine("menor que zero");
    }
    else
    {
        Console.WriteLine("igual a zero");
    }
}


// exemplo 4 -  instrução de uma única linha

if(number > 10)
    Console.WriteLine("maior que 10");
else
    Console.WriteLine("menor ou igual a 10");

// ou

if(number > 10) Console.WriteLine("maior que 10");
else Console.WriteLine("menor ou igual a 10");



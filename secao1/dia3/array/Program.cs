// EXEMPLO DE ARRAY DE INTEIROS
int[] myFirstArray1 = new int[] {1, 2, 3, 4, 5};
Console.WriteLine(myFirstArray1[0]);

int[] myFirstArray2 = {1, 2, 3, 4, 5};
int[] myArray = new int[4] {6, 9, 5, 8};

// EXEMPLO DE ARRAY DE STRINGS

string[] myFirsStringArray1 = new string[] {"Vamo", "que", "vamo", "!"};

string[] myFirsStringArray2 = {"Vamo", "que", "vamo", "!"};

// SE PASSAR UM INDICE ERRADO O CODIGO QUEBRA, E A SEQUENCIA EM CASCATA NÃO OCORRE
int[] myArray = new int[4] {6, 9, 5, 8};

// Console.WriteLine(myArray[4]);
// Saída: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

Console.WriteLine("Chegou Aqui!");
// Essa linha não será executada
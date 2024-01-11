List<string> stacksProjectA = new List<string> { "C#", "SQL Server", "JSON", "Microsserviços" };
List<string> stacksProjectB = new List<string> { "Java", "MySQL", "JSON", "WebAPI" };
List<string> stacksProjectC = new List<string> { "C#", "MySQL", "XML" };

// UNION - unir dois conjuntos OU TRES

var stacksProjectsAB = stacksProjectA.Union(stacksProjectB); // 2 unioes
foreach (var stack in stacksProjectsAB) {
    Console.WriteLine(stack);
}
// SAÍDA
// C#
// SQL Server
// JSON
// Microsserviços
// Java
// MySQL
// WebAPI

// OU

var stacksProjectsABC = stacksProjectA.Union(stacksProjectB).Union(stacksProjectC); // 3 unioes

foreach (var stack in stacksProjectsABC) {
    Console.WriteLine(stack);        
}


// INTERSECT -  intersecção dos valores de dois grupos COM coleção de elementos que estão presentes em ambas as coleções.
var stacksProjectsAandB = stacksProjectA.Intersect(stacksProjectB);

foreach (var stack in stacksProjectsAandB) {
    Console.WriteLine(stack); // RETORNO: JSON
}


// EXCEPT - conjunto de elementos menos os elementos de outro conjunto. O Q TENHO NO A Q NÃO TENHO NO B

var stacksProjectsAexceptB = stacksProjectA.Except(stacksProjectB);

foreach (var stack in stacksProjectsAexceptB) {
    Console.WriteLine(stack); // Java, MySQL, WebAPI
}

// DISTINCT - retornar uma coleção de uma coleção original sem repeti-los.

List<string> stacksProject = new List<string> { "C#", "SQL Server", "JSON", "C#", "XML", "SQL Server", "Microsserviços", "Microsserviços" };

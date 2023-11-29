// STRINGS - CONCAT()

string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";

string concatResult = string.Concat(textOne, textTwo, textThree);
Console.WriteLine(concatResult);


// SPLIT() - SPLIT(" ") - SPLIT("@") -> separação em múltiplas strings que ocorre de acordo com um separador especificado por parâmetro.

string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
string[] arrayEmails = emails.Split(";");
foreach (var email in arrayEmails)
{
  Console.WriteLine(email);
}

// INDEXOF -> retorna o index da primeira ocorrência referente ao caracter passado como parâmetro.
// CASO o valor não seja encontrado, é retornado -1. TAmbém pode passar o indice onde se inicia(segundo parametro)

// case 1 
string trybe = "Trybe";
int index = trybe.IndexOf("y"); // retorna o indice
// case 2
string trybe = "Trybe";
int index = trybe.IndexOf("s"); // retorna -1
//case 3
string trybe = "I love Trybe";
int index = trybe.IndexOf("e", 6); // retorna o e da Trybe, pois passou a posição
// case 4
string trybe = "I love Trybe";
int index = trybe.IndexOf("e", 13); // passando o indice errado da erro de exceção ArgumentOutOfRangeException


// Contains() -> É tipo includes, que retorna um boolean. Ele é case sensitive

List<string> languages = new List<string> 
{
 "c#",
 "java",
 "javascript",
 "python"
};

bool languageExists = languages.Contains("java");

if (languageExists) 
{
  Console.WriteLine("Essa linguagem existe no sistema");
}
else 
{
  Console.WriteLine("Essa linguagem não existe no sistema");
}


// Join() -> o primeiro parâmetro a ser passado é um valor separador e o segundo é a lista
// ele tem função de concatenar coleções de valores em uma string

IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
string numbersText = string.Join(',', listNumbers); 
// retorno: "1,2,3,4,5,6,7,8,9,10"
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string Name1 = "Maria";
double Ages = 29.5;
int Amount = 10;


Console.WriteLine(Name1);
Console.WriteLine(Ages);
Console.WriteLine(Amount);

//Entrada de Dados
// O erro do warn acontece pois elel não tem a certeza se a pessoa passará o valor no input
int? Age = int.Parse(Console.ReadLine());
decimal Average = decimal.Parse(Console.ReadLine());
bool Permission = bool.Parse(Console.ReadLine());
string Name = Console.ReadLine();

//Exemplo de concatenação de Dados
int Number = 10;
string Name3 = "Trybe";
Console.WriteLine("O valor da variável numero é: "+Number);
Console.WriteLine("Eu sou um estudante " + Name3 +"!");



//ENTRADA DE DADOS

Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");


Console.WriteLine("Informe o nome do cômodo: ");
string convenient = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
int power = int.Parse(Console.ReadLine());

//PROCESSAMENTO
decimal squareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLightBulbs = squareMeter / quotientX;

//SAIDA DE DADOS
Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessário a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");



  //esta variável será compilada como string
var school = "Trybe";

//esta variável será compilada como int
var semester = 1;

//esta variável será compilada como um tipo anônimo
var student = new { name = "Jorge", age = 30 };

Console.WriteLine("Olá! Me chamo " + student.name + " " +
                  "sou um estudante da escola " + school + " " +
                  "estou no " + semester + "º semestre " +
                  "e tenho " + student.age + " anos"); 



// OPERAÇÕES ARITMÉTICAS

//Adição
int a = 50, b = 50;
int result1 = a + b;
Console.WriteLine(a + " + " + b + " = " + result1);

//Subtração
int c = 77, d = 21;
int result2 = c - d;
Console.WriteLine(c + " - " + d + " = " + result2);

//Multiplicação
int e = 5, f = 5;
int result3 = e * f;
Console.WriteLine(e + " * " + f + " = " + result3);

//divisão
int g = 90, h = 9;
int result4 = g / h;
Console.WriteLine(g + " / " + h + " = " + result4);

//módulo
int i = 36, j = 7;
int result5 = i % j;
Console.WriteLine("O resto da divisão de "+i+" por "+j+" é "+result5);



//ordem de execução - multiplicação e div primeiro (pode usar ordem de parenteses)
int aa = 5, bb = 10, cc = 15;
int result6 = (aa + bb * cc);
Console.WriteLine("("+aa+" + "+bb+" * "+cc+") = "+result6);

//utilizando parênteses
int result7 = ((aa + bb) * cc);
Console.WriteLine("((" + aa + " + " + bb + ") * " + cc + ") = " + result7);



// ATRIBUIÇÃO REDUZIDA
int a1 = 1;
//incrementa + 1 ao valor de a
a1++; //substitui a instrução a = a + 1 
Console.WriteLine("A = "+a1);

int b1 = 10;
//decrementa o -1 ao valor b
b1--; //substitui a instrução b = b - 1
Console.WriteLine("B = " + b1);

//incrementa qualquer valor à direita na variável à esquerda
int c1 = 23;
c1 += 15; //substitui a instrução c = c + 15 
Console.WriteLine("C = " + c1);

//incrementa multiplicando qualquer valor à direita na variável à esquerda
int e1 = 11;
e1 *= 3; //substitui a instrução e = e * 3 
Console.WriteLine("E = " + e1);

//decrementa dividindo qualquer valor à direita na variável à esquerda
decimal f1 = 11;
f1 /= 3; //substitui a instrução f = f / 3 
Console.WriteLine("F = " + f1.ToString("N2"));

//decrementa com a operação de módulo de qualquer valor à direita na variável à esquerda
decimal g1 = 11;
g1 %= 3; //substitui a instrução g = g % 3 
Console.WriteLine("G = " + g1.ToString("N2"));
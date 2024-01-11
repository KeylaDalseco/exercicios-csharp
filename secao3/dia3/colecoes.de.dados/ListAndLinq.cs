// objeto do tipo lista simples:
List<string> brands = new List<string>();
List<string> brands2 = new List<string>(){ "samsung", "dell", "apple", "HP" };

// Os métodos mais utilizados com listas são: .Add(), .Remove(), .RemoveAt(), .IndexOf() e .Sort()

List<string> cars = new List<string>(){ "Fusca", "Corsa" };

// .Add() - adiciona o item no final da lista
cars.Add("Brasília");
cars.ForEach(car => {
    Console.WriteLine(car);
});

// .Remove() - remove o último elemento OU  o desejado
cars.Remove("Fusca");

// .RemoveAt() - removemos um item específico da lista, enviando por parâmetro o índice do objeto
cars.RemoveAt(1);

// .IndexOf() - encontra o índice de um determinado elemento

List<int> integers = new List<int>(){ 18, 45, 29, 99 };

Console.WriteLine(integers.IndexOf(29));

// .Sort() - ordenarmos a nossa lista por critérios específicos - ordenação desejada, utilizando a ordenação padrão, ordem alfabética ou numérica

List<string> animals = new List<string>(){ "cachorro", "baleia", "urso", "tigre" };

animals.Sort();
animals.ForEach(animal => {
    Console.WriteLine(animal);
});


// LINQ - CONSULTAS EM BANCO DE DADOS

string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"}; // SEQUENCIA 

IEnumerable<string> filteredGames = from game in games
                                    where game.Contains('a')
                                    select game;

// ou implícito:
var filteredGames2 = from game in games
                    where game.Contains('a')
                    select game;

// E verificar o resultado da consulta com um laço:

foreach(var game in filteredGames)
{
    Console.WriteLine(game);
}



// OPERADORES DE FILTRAGEM

namespace ARTISTS
{

internal class Artist
  {
    public string? name { get; set; }
    public int listeners { get; set; }
  }


var artists = new List<Artist>
      {
        new Artist { name = "Raul Seixas", listeners = 50000 },
        new Artist { name = "Mozart", listeners = 15000 },
        new Artist { name = "Elvis Presley", listeners = 25000 },
        new Artist { name = "Bob Dylan", listeners = 30000 },
        new Artist { name = "Guns N' Roses", listeners = 40000 },
      };

var topListeners =
               from artist in artists
               where artist.listeners > 30000
               select artist.name; // retorne so o nome

foreach(var artist in topListeners)
{
   Console.WriteLine(artist);
}

}

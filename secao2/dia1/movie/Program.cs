class Program
{
    public static void Main(string[] args){
      var movie1 = new Movie("Matrix", "Ficção científica");
      var movie2 = new Movie("Barbie", "Animação");

    Console.WriteLine(movie1.Title);
    Console.WriteLine(movie2.Category);
    }
}


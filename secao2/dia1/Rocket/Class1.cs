namespace Rocket;
class Rockets
{
  public string _Name { get; set; }
  int Fuel { get; set; } = 0;  // declaração default
  int _fuel;
  int _maxFuel = 5000;

  public int FieldAsPercentage
  {
      get { return _fuel * 100 / _maxFuel; }
      set {
          if (value > 100 || value < 0)
              throw new ArgumentOutOfRangeException();

          _fuel = (value * _maxFuel) / 100;
        }
  }
  decimal Price { get; set; }
  public Rockets(string name, decimal price) // esse é o contructor
  {
    _Name = name;
    Fuel = 0; // se tiver a default não precisa dela aqui
    Price = price;
  }
}


// ABAIXO DE EXEMPLO COMO INSTANCIAR UMA CLASSE DENTRO DE OUTRA.
// class Program
//     {
//         static void Main(string[] args)
//         {
//             var rocket1 = new Rockets();
//             rocket1.Name = "Apollo 11";
//             Console.WriteLine(rocket1.Name);

//             var rocket2 = new Rockets();
//             rocket2.Name = "Falcon 9";
//             Console.WriteLine(rocket2.Name);
//         }
//     }
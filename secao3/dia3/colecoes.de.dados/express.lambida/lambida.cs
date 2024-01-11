namespace cars
{
  public class Car2 {
      public string? Brand { get; set; }
      public string? Model { get; set; }
      public float Price { get; set; }
  }

  public class Program
  {
    public static void Main()
    {

  List<Car> cars = new List<Car>
  {
      new Car { Brand = "Ferrari", Model = "LaFerrari", Price = 7100000 },
      new Car { Brand = "McLaren", Model = "Elva", Price = 8600000 },
      new Car { Brand = "Bentley", Model = "Mulliner Batur", Price = 10200000 },
      new Car { Brand = "Aston Martin", Model = "Valkyrie", Price = 16300000 },
      new Car { Brand = "BMW", Model = "IX", Price = 670000 },
      new Car { Brand = "Bugatti", Model = "Divo", Price = 26000000 },
      new Car { Brand = "Ferrari", Model = "F8 Spider", Price = 5200000 },
      new Car { Brand = "McLaren", Model = "Speedtail", Price = 40000000 },
      new Car { Brand = "Koenigsegg", Model = "Agera", Price = 7500000 },
      new Car { Brand = "Devel", Model = "Sixteen", Price = 79000020 }
  };

var carsName = cars.Select(car => car.Brand + " " + car.Model); // SELECT
var carsFerrari = cars.Where(car => car.Brand == "Ferrari"); // WHERE
var carsOrderedByPrice = cars.OrderBy(car => car.Price); // ORDERBY

bool allCarsOver15M = cars.All(car => car.Price > 15000000); // ALL
Console.WriteLine($"Todos os carros custam mais de 15M? {allCarsOver15M}");

bool anyCarsOver15M = cars.Any(car => car.Price > 15000000); // ANY
Console.WriteLine($"Algum carro custa mais de 15M? {anyCarsOver15M}");


var minPrice = cars.Min(car => car.Price); // MIN
Console.WriteLine($"O carro mais barato custa: R$ {minPrice}");

var maxPrice = cars.Max(car => car.Price); // MAX
Console.WriteLine($"O carro mais caro custa: R$ {maxPrice}");

var avgPrice = cars.Average(car => car.Price); // AVERAGE
Console.WriteLine($"Os carros custam em média: R$ {avgPrice}");

var carsByBrand = cars.GroupBy(car => car.Brand); // AGRUPAMENTO

foreach(var carName in carsName)
{
    Console.WriteLine(carName);
}

  }
    }

    
}




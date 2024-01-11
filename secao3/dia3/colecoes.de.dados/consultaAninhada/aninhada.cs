// CONSULTAS ANINHADAS
public class Car {
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public float Price { get; set; }
}


public class Category {
    public string? Name;
    public List<Car>? Cars;
}

List<Category> categoryCars = new List<Category>
{
    new Category { Name = "Luxury", Cars = new List<Car> {
                    new Car { Brand = "Ferrari", Model = "LaFerrari", Price = 7100000 },
                    new Car { Brand = "McLaren", Model = "Elva", Price = 8600000 },
                    new Car { Brand = "Bentley", Model = "Mulliner Batur", Price = 10200000 },
                    new Car { Brand = "Aston Martin", Model = "Valkyrie", Price = 16300000 },
                    new Car { Brand = "BMW", Model = "IX", Price = 670000 }
                }},
    new Category { Name = "Sport", Cars = new List<Car> {
                    new Car { Brand = "Bugatti", Model = "Divo", Price = 26000000 },
                    new Car { Brand = "Ferrari", Model = "F8 Spider", Price = 5200000 },
                    new Car { Brand = "McLaren", Model = "Speedtail", Price = 40000000 },
                    new Car { Brand = "Koenigsegg", Model = "Agera", Price = 7500000 },
                    new Car { Brand = "Devel", Model = "Sixteen", Price = 79000020 }
                }}
};

var carsSport = from category in categoryCars
                where category.Name == "Sport"
                select new {
                  category.Name,
                  Cars = from car in category.Cars
                          where car.Price > 30000000
                          select car
                };



// CONSULTAS ANINHADAS EM AGRUPAMENTO

// -> Aqui o retorno terá a inclusão da categoria
 var carsByBrand = from categoryCar in categoryCars
                   from car in categoryCar.Cars
                   select new {
                        car.Brand,
                        car.Model,
                        car.Price,
                        CategoryName = categoryCar.Name
                    } into grupoA
                    orderby grupoA.Price
                    group grupoA by grupoA.Brand;


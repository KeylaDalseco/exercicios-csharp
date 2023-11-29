using Rocket;

var rocket1 = new Rockets();
var rocket2 = rocket1;

rocket1._Name = "Apollo 11";
rocket2._Name = "Falcon 9";

Console.WriteLine(rocket1._Name);
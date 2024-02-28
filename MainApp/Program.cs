using Domain.Models;
using Infrastructure.Services;

var car1 = new Car();
car1.Id = 1;
car1.Name = "Mersedes";
car1.Color = "black";
car1.Model = "GLE";
car1.Weight = 2000;
car1.Price = 50000;

var car2 = new Car();
car2.Id = 2;
car2.Name = "BMW";
car2.Color = "blue";
car2.Model = "X5";
car2.Weight = 1800;
car2.Price = 36000;

var car3 = new Car();
car3.Id = 3;
car3.Name = "Audi";
car3.Color = "white";
car3.Model = "M8";
car3.Weight = 1500;
car3.Price = 20000;

var car4 = new Car();
car4.Id = 2;
car4.Name = "Bugati";
car4.Color = "red";
car4.Model = "Veron";
car4.Weight = 2000;
car4.Price = 10000000;

var carService = new CarService();
carService.AddCar(car1);
carService.AddCar(car2);
carService.AddCar(car3);

for(;;)
{
    System.Console.WriteLine("Baroi barovardani moshinxo get navised: ");
    System.Console.WriteLine("Baroi barovardan bo id getbyid navised: ");
    System.Console.WriteLine("Baroi dob kardani moshin add navised: ");
    System.Console.WriteLine("Baroi obnovit kardani moshin update navised: ");
    System.Console.WriteLine("Baroi udalit kardani moshin delete navised: ");
    string funksiya = Console.ReadLine();
    if(funksiya=="get")
    {
        foreach (var item in carService.GetCars())
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Color);
            System.Console.WriteLine(item.Model);
            System.Console.WriteLine(item.Weight);
            System.Console.WriteLine(item.Price);
        }
    }
    else if(funksiya=="getbyid")
    {
        System.Console.WriteLine("Kadom Moshinro barorem,id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        carService.GetById(id);
    }
    else if(funksiya=="add")
    {
        var car = new Car();
        System.Console.Write("Id: ");
        car.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Name: ");
        car.Name = Console.ReadLine();
        System.Console.Write("Color: ");
        car.Color = Console.ReadLine();
        System.Console.Write("Model: ");
        car.Model = Console.ReadLine();
        System.Console.Write("Weight: ");
        car.Weight = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Price: ");
        car.Price = Convert.ToDecimal(Console.ReadLine());
        carService.AddCar(car);
        System.Console.WriteLine("Moshin dar listi moshinho dobavit shud!");
        System.Console.WriteLine("----------------------------------------");
    }
    else if(funksiya=="update")
    {
         var car = new Car();
        System.Console.Write("Kadom moshina mexohen izmenit knen, id: ");
        car.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Name: ");
        car.Name = Console.ReadLine();
        System.Console.Write("Color: ");
        car.Color = Console.ReadLine();
        System.Console.WriteLine("Model: ");
        car.Model = Console.ReadLine();
        System.Console.WriteLine("Weight: ");
        car.Weight = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Price: ");
        car.Price = Convert.ToDecimal(Console.ReadLine());
        carService.UpdateCar(car);
        System.Console.WriteLine("Parametroi moshin alish shidan!");
        System.Console.WriteLine("----------------------------------------");
    }
    else if(funksiya=="delete")
    {
        System.Console.WriteLine("Kadom moshinro udalit kunem,id: ");
        int del = Convert.ToInt32(Console.ReadLine());
        carService.DeleteCar(del);
        System.Console.WriteLine("Moshin udalit shud!");
        System.Console.WriteLine("----------------------------------------");
    }
}
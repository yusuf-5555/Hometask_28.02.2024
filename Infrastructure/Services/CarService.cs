using Domain.Models;
namespace Infrastructure.Services;

public class CarService
{
    List<Car> _cars = new List<Car>();

    public List<Car> GetCars()
    {
        return _cars;
    }
    public void GetById(int id)
    {
       var hello = _cars.FirstOrDefault(n=>n.Id==id);
       
       System.Console.WriteLine(hello.Id);
       System.Console.WriteLine(hello.Name);
       System.Console.WriteLine(hello.Color);
       System.Console.WriteLine(hello.Model);
       System.Console.WriteLine(hello.Weight);
       System.Console.WriteLine(hello.Price);
    }
    public void AddCar(Car car)
    {
        _cars.Add(car);
    }
    public void UpdateCar(Car car)
    {
        var update = _cars.FirstOrDefault(n=>n.Id==car.Id);
        update.Id = car.Id;
        update.Name = car.Name;
        update.Color=car.Color;
        update.Model=car.Model;
        update.Weight = car.Weight;
        update.Price=car.Price;
    }
    public void DeleteCar(int id)
    {
        var delete = _cars.FirstOrDefault(n=>n.Id==id);
        _cars.Remove(delete);
    }
}
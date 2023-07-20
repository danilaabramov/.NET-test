using testNET.Data.Interfaces;
using testNET.Data.Models;

namespace testNET.Data.mocks;

public class MockCars : IAllCars
{
    private readonly ICarsCategory _categoryCars = new MockCategory();

    public IEnumerable<Car> Cars => new List<Car>
    {
        new Car
        {
            name = "Tesla Model S", shortDesc = "Быстрый автомобиль",
            longDesc = "Красивый и очень тихий автомобиль компании Tesla",
            img =
                "https://digitalassets.tesla.com/tesla-contents/image/upload/h_998,w_1800,c_fit,f_auto,q_auto:best/Model-S-Order-Hero-Desktop-Mobile-LHD",
            price = 45000,
            isFavorite = true, available = true, Category = _categoryCars.AllCategories.First()
        }
    };

    public IEnumerable<Car> getFavCars { get; set; }

    public Car getObjectCar(int carId) => throw new NotImplementedException();
}
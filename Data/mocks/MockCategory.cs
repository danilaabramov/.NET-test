using testNET.Data.Interfaces;
using testNET.Data.Models;

namespace testNET.Data.mocks;

public class MockCategory : ICarsCategory
{
    public IEnumerable<Category> AllCategories =>
        new List<Category>
        {
            new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
            new Category { categoryName = "Классичесские автомобили", desc = "Машины с двигателем внутреннего згорания" }
        };
}
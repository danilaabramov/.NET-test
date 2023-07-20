using testNET.Data.Models;

namespace testNET.Data.Interfaces;

internal interface ICarsCategory
{
    IEnumerable<Category> AllCategories { get; }
}
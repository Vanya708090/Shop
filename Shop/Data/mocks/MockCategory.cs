using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoreName = "Электромобили", desk = "Современный вид транспорта"},
                    new Category{categoreName = "Классические автомобили", desk = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}


using Shop.Data.Interfeses;
using Shop.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
              get
              {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили" , desc = "Cовременный вид транспорта "},
                    new Category { categoryName = "Классический Автомобиль", desc = "Машина с двигателем внктреннего сгорания"}
                };
              }
        }
    }
}

    

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           


            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Car.Any())
            {
                content.AddRange(
                      new Car
                      {
                          name = "Tesla",
                          shortDesc = "Быстрый автомобиль",
                          longDesc = "Красивый, быстрый и очень тихий автомобиль Tesla",
                          img = "/img/red-car.jpg",
                          price = 45000,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Электромобили"]
                      }
                    );
            }
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили" , desc = "Cовременный вид транспорта "},
                        new Category { categoryName = "Классический Автомобиль", desc = "Машина с двигателем внктреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }

}

using Shop.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfeses
{
    public interface ICarsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}

using System.Collections.Generic;
using CoreMVC3.Data.Entities;

namespace CoreMVC3.Data
{
    public interface IDutchRepository
    {
         IEnumerable<Product> GetAllProducts ();
         IEnumerable<Product> GetProductsByCategory(string category);
         bool SaveAll();

    }
}
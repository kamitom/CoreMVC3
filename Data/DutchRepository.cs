using System.Collections.Generic;
using System.Linq;
using CoreMVC3.Data.Entities;

namespace CoreMVC3.Data {
    public class DutchRepository : IDutchRepository
    {
        private DutchContext _Ctx { get; }
        public DutchRepository (DutchContext ctx) {
            this._Ctx = ctx;
        }

        public IEnumerable<Product> GetAllProducts () {
            return _Ctx.Products
                .OrderBy (p => p.Title)
                .ToList ();
        }

        public IEnumerable<Product> GetProductsByCategory (string category) {
            return _Ctx.Products.Where (p => p.Category == category).ToList ();
        }

        public bool SaveAll() {
            return _Ctx.SaveChanges() > 0 ;
        }



    }
}
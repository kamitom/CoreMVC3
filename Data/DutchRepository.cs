using System.Collections.Generic;
using System.Linq;
using CoreMVC3.Data.Entities;
using Microsoft.Extensions.Logging;

namespace CoreMVC3.Data {
    public class DutchRepository : IDutchRepository {
        private DutchContext _Ctx { get; }
        // public ILogger<DutchRepository> _logger { get; }
        public readonly ILogger<DutchRepository> _logger;
        public DutchRepository (DutchContext ctx, ILogger<DutchRepository> logger) {
            this._logger = logger;
            this._Ctx = ctx;
        }

        public IEnumerable<Product> GetAllProducts () {
            try {
                _logger.LogInformation ("GetAllProducts was called");
                return _Ctx.Products
                    // .OrderBy (p => p.Title)
                    .OrderBy (p => p.Artist)
                    .ToList ();

            } catch (System.Exception ex) {
                _logger.LogError ($"Fail to get all products: {ex.Message}");
                return null;
                // throw;
            }

        }

        public IEnumerable<Product> GetProductsByCategory (string category) {
            return _Ctx.Products.Where (p => p.Category == category).ToList ();
        }

        public bool SaveAll () {
            return _Ctx.SaveChanges () > 0;
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CoreMVC3.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace CoreMVC3.Data {
    public class DutchSeeder {
        private DutchContext _Ctx { get; }
        private IHostingEnvironment _Hosting { get; }

        public DutchSeeder (DutchContext ctx, IHostingEnvironment hosting) {
            this._Hosting = hosting;
            this._Ctx = ctx;
        }

        public void Seed () {

            _Ctx.Database.EnsureCreated ();

            if (!_Ctx.Products.Any ()) {
                // need to create simple data
                var filepath = Path.Combine (_Hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText (filepath);

                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);

                _Ctx.Products.AddRange(products);

                var order = new Order(){
                    OrderDate = DateTime.Now,
                    OrderNumber = "99889",
                    Items = new List<OrderItem>() {
                        new OrderItem(){
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    }
                };

                _Ctx.Orders.Add(order);
                _Ctx.SaveChanges();
            }
        }
    }
}
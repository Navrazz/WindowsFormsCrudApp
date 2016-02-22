using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApplication.Model
{
    public partial class Product
    {
        /// <summary>
        /// Funkcja zwracająca wszystkie produkty
        /// </summary>
        /// <param name="dataContext"></param>
        /// <returns></returns>
        public static IQueryable<Product> GetAllProducts(DataClassesCrudApplicationDataContext dataContext)
        {
            return from product in dataContext.Products select product;
        }
    }
}

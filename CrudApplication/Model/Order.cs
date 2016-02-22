using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApplication.Model
{
    public partial class Order
    {
        /// <summary>
        /// Funkcja zwracająca wszystkie zamówienia
        /// </summary>
        /// <param name="dataContext"></param>
        /// <returns></returns>
        public static IQueryable<Order> GetAllOrders(DataClassesCrudApplicationDataContext dataContext)
        {
            return from order in dataContext.Orders select order;
        }
    }
}

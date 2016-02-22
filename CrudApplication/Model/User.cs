using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudApplication.Model
{
    public partial class User
    {
        /// <summary>
        /// Funkcja zwracająca wszystkich klientów
        /// </summary>
        /// <param name="dataContext"></param>
        /// <returns></returns>
        public static IQueryable<User> GetAllCustomers(DataClassesCrudApplicationDataContext dataContext)
        {
            return from user in dataContext.Users where user.IsAdmin == false select user;
        }

        /// <summary>
        /// Funkcja zwracająca wszystkich adminów
        /// </summary>
        /// <param name="dataContext"></param>
        /// <returns></returns>
        public static IQueryable<User> GetAllAdmins(DataClassesCrudApplicationDataContext dataContext)
        {
            return from user in dataContext.Users where user.IsAdmin == true select user;
        }
    }
}

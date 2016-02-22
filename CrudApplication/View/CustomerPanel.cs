using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudApplication.Model;

namespace CrudApplication.View
{
    public partial class CustomerPanel : Form
    {
        User user;
        DataClassesCrudApplicationDataContext dataContext = new DataClassesCrudApplicationDataContext();
        public CustomerPanel(User user)
        {
            InitializeComponent();
            this.user = user;
            labelWelcome.Text = "Welcome " + user.Login + " (" + user.Name + " " + user.LastName + ")"; //wyświetlenie loginu, imienia oraz nazwiska zalogowanego użytkownika
            var query = Product.GetAllProducts(dataContext);
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
        }

        /// <summary>
        /// Wyświetlenie wszystkich produktów
        /// </summary>
        private void buttonShowAllProduct_Click(object sender, EventArgs e)
        {
            var query = Product.GetAllProducts(dataContext);
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
            buttonOrderProduct.Enabled = true;
        }

        /// <summary>
        /// Wyświetlenie zamówień danego klienta
        /// </summary>
        private void buttonShowMyOrders_Click(object sender, EventArgs e)
        {
            var query = from order in dataContext.Orders join product in dataContext.Products on order.ProductId equals product.Id
                        where order.UserId == user.Id select new { Order_Id = order.OrderId, Product = product.Name, order.Quantity, Realised = order.IsComplete};
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
            buttonOrderProduct.Enabled = false;
        }

        /// <summary>
        /// Zamawianie produktów
        /// </summary>
        private void buttonOrderProduct_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.UserId = user.Id;
            order.ProductId = Int32.Parse(textBoxId.Text);
            order.Quantity = Int32.Parse(textBoxQuantity.Text);
            order.IsComplete = false;
            dataContext.Orders.InsertOnSubmit(order);
            dataContext.SubmitChanges();
        }

        private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = dataGridViewShow.CurrentCell.Value.ToString();
        }
    }
}

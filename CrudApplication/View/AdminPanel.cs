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
    public partial class AdminPanel : Form
    {
        DataClassesCrudApplicationDataContext dataContext = new DataClassesCrudApplicationDataContext();
        User user;

        public AdminPanel(User user)
        {
            InitializeComponent();
            this.user = user;
            labelWelcome.Text = "Welcome " + user.Login +" ("+user.Name+" "+user.LastName+")"; //wyświetlenie loginu, imienia oraz nazwiska zalogowanego użytkownika
            var query = User.GetAllCustomers(dataContext);
            RefreshDataGridView(query);
        }
        
        /// <summary>
        /// Wyświetlenie wszystkich klientów
        /// </summary>
        private void buttonShowAllCustomers_Click(object sender, EventArgs e)
        {
            var query = User.GetAllCustomers(dataContext);
            RefreshDataGridView(query);
            buttonCustomerOrder.Enabled = true;
            buttonMarkComplete.Enabled = false;
            buttonDeleteUser.Enabled = true;
            buttonGiveAdmin.Enabled = true;
            buttonRemoveAdmin.Enabled = false;
        }

        /// <summary>
        /// Wyświetlenie wszystkich adminów
        /// </summary>
        private void buttonShowAllAdmins_Click(object sender, EventArgs e)
        {
            var query = User.GetAllAdmins(dataContext);
            RefreshDataGridView(query);
            buttonCustomerOrder.Enabled = false;
            buttonMarkComplete.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonGiveAdmin.Enabled = false;
            buttonRemoveAdmin.Enabled = true;
        }

        /// <summary>
        /// Wyświetlenie wszystkich produktów
        /// </summary>
        private void buttonShowAllProduct_Click(object sender, EventArgs e)
        {
            var query = Product.GetAllProducts(dataContext);
            RefreshDataGridView(query);
            buttonCustomerOrder.Enabled = false;
            buttonMarkComplete.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonGiveAdmin.Enabled = false;
            buttonRemoveAdmin.Enabled = false;
        }

        /// <summary>
        /// Dodanie nowego produktu
        /// </summary>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AdminPanelAddProduct addProduct = new AdminPanelAddProduct();
            addProduct.Show();
            var query = Product.GetAllProducts(dataContext);
            RefreshDataGridView(query);
        }

        /// <summary>
        /// Nadanie praw Admina konkretnemu użytkownikowi
        /// </summary>
        private void buttonGiveAdmin_Click(object sender, EventArgs e)
        {
            User temporaryUser = (from user in dataContext.Users where user.Id == Int64.Parse(textBoxId.Text) select user).FirstOrDefault();
            temporaryUser.IsAdmin = true;
            dataContext.SubmitChanges();
            var query = User.GetAllAdmins(dataContext);
            RefreshDataGridView(query);
        }

        /// <summary>
        /// Odebranie praw admina konkretnemu użytkownikowi
        /// </summary>
        private void buttonRemoveAdmin_Click(object sender, EventArgs e)
        {
            //Sprawdzenie czy Id użytkownika któremu chcemy zabrać prawa admina jest takie jak Id zalogowanego admina. Jeśli tak, wyświetlenie błędu
            if (user.Id == Int64.Parse(textBoxId.Text))
            {
                MessageBox.Show("You can't remove yourself");
            }
            else
            {
                User temporaryUser = (from user in dataContext.Users where user.Id == Int64.Parse(textBoxId.Text) select user).FirstOrDefault();
                temporaryUser.IsAdmin = false;
                dataContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Usunięcie użytkownika
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Sprawdzenie czy Id użytkownika którego chcemy usunąć jest takie jak Id zalogowanego użytkownika. Jeśli tak, wyświetlenie błędu
            if (user.Id == Int64.Parse(textBoxId.Text))
            {
                MessageBox.Show("You can't remove yourself");
            }
            else
            {
                User temporaryUser = (from user in dataContext.Users where user.Id == Int32.Parse(textBoxId.Text) select user).FirstOrDefault();
                dataContext.Users.DeleteOnSubmit(temporaryUser);
                dataContext.SubmitChanges();
                var query = User.GetAllCustomers(dataContext);
                RefreshDataGridView(query);
            }

        }

        /// <summary>
        /// Wyświetlenie wszystkich zamówień
        /// </summary>
        private void buttonAllOrders_Click(object sender, EventArgs e)
        {
            var query = from order in dataContext.Orders
                        join product in dataContext.Products on order.ProductId equals product.Id
                        join user in dataContext.Users on order.UserId equals user.Id
                        where order.UserId == user.Id
                        select new { Order_Id = order.OrderId, Customer = user.Login, Product = product.Name, order.Quantity, Realised = order.IsComplete };
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
            buttonCustomerOrder.Enabled = false;
            buttonMarkComplete.Enabled = true;
            buttonDeleteUser.Enabled = false;
            buttonGiveAdmin.Enabled = false;
            buttonRemoveAdmin.Enabled = false;
        }

        /// <summary>
        /// Wyświetlenie zamówień konkretnego użytkownika
        /// </summary>
        private void buttonCustomerOrder_Click(object sender, EventArgs e)
        {
            var query = from order in dataContext.Orders
                        join product in dataContext.Products on order.ProductId equals product.Id
                        join user in dataContext.Users on order.UserId equals user.Id
                        where order.UserId == Int32.Parse(textBoxId.Text)
                        select new { Order_Id = order.OrderId, Customer = user.Login, Product = product.Name, order.Quantity, Realised = order.IsComplete };
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
        }

        /// <summary>
        /// Oznaczenie zamówienia jako zrealizowane
        /// </summary>
        private void buttonMarkComplete_Click(object sender, EventArgs e)
        {
            Order temporaryOrder = (from order in dataContext.Orders where order.OrderId == Int32.Parse(textBoxId.Text) select order).FirstOrDefault();
            temporaryOrder.IsComplete = true;
            dataContext.SubmitChanges();
        }

        private void RefreshDataGridView(IQueryable<User> query)
        {
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
        }

        private void RefreshDataGridView(IQueryable<Product> query)
        {
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
        }

        private void RefreshDataGridView(IQueryable<Order> query)
        {
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShow.DataSource = query;
        }

        private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = dataGridViewShow.CurrentCell.Value.ToString();
        }
    }
}

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
    public partial class AdminPanelAddProduct : Form
    {
        DataClassesCrudApplicationDataContext dataContext = new DataClassesCrudApplicationDataContext();
        public AdminPanelAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Sprawdzenie czy wszystkie pola są wypełnione. Jeśli nie, wyświetlenie błędu.
            if (string.IsNullOrEmpty(textBoxProductName.Text) || string.IsNullOrEmpty(textBoxProductPrice.Text))
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                Product product = new Product();
                product.Name = textBoxProductName.Text;
                product.Price = textBoxProductPrice.Text;
                dataContext.Products.InsertOnSubmit(product);
                dataContext.SubmitChanges();
                Close();
            }
        }
    }
}

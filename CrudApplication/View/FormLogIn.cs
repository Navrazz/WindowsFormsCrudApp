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
using CrudApplication.View;


namespace CrudApplication
{
    public partial class FormLogIn : Form
    {
        DataClassesCrudApplicationDataContext dataContext = new DataClassesCrudApplicationDataContext();

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var isAdmin = from user in dataContext.Users
                          where user.Login == textBoxLogin.Text && user.Password == textBoxPassword.Text && user.IsAdmin == true
                          select user;

            var isCustomer = from user in dataContext.Users
                        where user.Login == textBoxLogin.Text && user.Password == textBoxPassword.Text
                        select user;

            //Sprawdzenie, czy użytkownik jest administratorem. Jeśli tak, wyświetlenie panelu administratora
            if (isAdmin.Count() > 0)
            {
                User tempUser = (isAdmin).FirstOrDefault();
                AdminPanel adminPanel = new AdminPanel(tempUser);
                adminPanel.Show();
            }

            //Sprawdzenie, czy użytkownik jest klientem. Jeśli tak, wyświetlenie panelu klienta
            else if (isCustomer.Count() > 0)
            {
                User tempUser = (isCustomer).FirstOrDefault();
                CustomerPanel customerPanel = new CustomerPanel(tempUser);
                customerPanel.Show();
            }

            //Jeśli użytkownik nie istnieje, wyświetlenie błędu
            else
            {
                MessageBox.Show("Login or password incorrect!");
            }
        }
    }
}

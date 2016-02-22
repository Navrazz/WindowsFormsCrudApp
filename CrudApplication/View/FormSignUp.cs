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

namespace CrudApplication
{
    public partial class FormSignUp : Form
    {
        DataClassesCrudApplicationDataContext dataContext = new DataClassesCrudApplicationDataContext();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //Wprawdzenie czy wszystkie pola są wypełnione
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || 
                string.IsNullOrWhiteSpace(textBoxLastName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) || 
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Fill all fields!");
            }

            //Sprawdzenie czy istnieje użytkownik o danym loginie. Jeśli tak, rejestracja nie jest możliwa
            else if ((from user in dataContext.Users where user.Login == textBoxLogin.Text select user).Count() > 0)
            {
                MessageBox.Show("Login is not available!");
            }
            else
            {
                User user = new User();
                user.Login = textBoxLogin.Text;
                user.Password = textBoxPassword.Text;
                user.Name = textBoxName.Text;
                user.LastName = textBoxLastName.Text;
                user.Email = textBoxEmail.Text;
                user.PhoneNumber = textBoxPhoneNumber.Text;
                user.Address = textBoxAddress.Text;
                user.IsAdmin = false;
                dataContext.Users.InsertOnSubmit(user);
                dataContext.SubmitChanges();
                Close();
            }
        }
    }
}

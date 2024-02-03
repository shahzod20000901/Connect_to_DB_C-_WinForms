using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_to_DB
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            nameField.ForeColor = Color.Gray;
            surenameField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            nameField.Text = "";
            nameField.ForeColor = Color.Black;
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.ForeColor = Color.Gray;
                nameField.Text = "Введите имя";

            }    
           
        }

        private void SurenameField_Enter(object sender, EventArgs e)
        {
            surenameField.Text = "";
            surenameField.ForeColor= Color.Black;
        }

        private void SurenameField_Leave(object sender, EventArgs e)
        {
            if (surenameField.Text == "")
            {
                surenameField.ForeColor = Color.Gray;
                surenameField.Text = "Введите фамилию";

            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            loginField.Text = "";
            loginField.ForeColor = Color.Black;
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "Введите логин";
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            passwordField.Text = "";
            passwordField.ForeColor = Color.Black;
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if(passwordField.Text=="")
            {
                passwordField.Text = "Введите пароль";
                passwordField.ForeColor = Color.Gray;

            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DB db=new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surename`) VALUES (@log, @pass, @name, @surename)", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surename", MySqlDbType.VarChar).Value = surenameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        }
    }
}

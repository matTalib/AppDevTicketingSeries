using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            using (var conn = DbHelper.GetConnection())
            {
                var admin = conn.QueryFirstOrDefault<Admin>(
                    "Select * FROM Admin Where Username = @Username AND Password = @Password",
                    new { Username = username, Password = password });

                if (admin != null)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }

        }
    }
}

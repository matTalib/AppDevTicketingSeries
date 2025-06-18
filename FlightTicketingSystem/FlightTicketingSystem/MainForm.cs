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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            AircraftForm aircraftForm = new AircraftForm();
            aircraftForm.ShowDialog();
        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            FlightForm flightForm = new FlightForm();
            flightForm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            ViewBookingForm viewBookingForm = new ViewBookingForm();
            viewBookingForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                this.Hide();

                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        //private void btnTestConnection_Click(object sender, EventArgs e)
        //{
        //    using (var conn = DbHelper.GetConnection())
        //    {
        //        conn.Open();
        //        MessageBox.Show("Connection is successful!");
        //    }

        //}
    }
}

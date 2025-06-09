using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketingSystem
{
    public partial class AircraftForm : Form
    {
        public AircraftForm()
        {
            InitializeComponent();
        }

        private void btnAddAicraft_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int totalSeats = (int)numSeats.Value;

            if (string.IsNullOrEmpty(name) || totalSeats <= 0)
            {
                MessageBox.Show("Please enter valid aircraft details.");
                return;
            }

            char[] seatColumns = { 'A', 'B', 'C', 'D', 'E', 'F' };
            int SeatsPerRow = seatColumns.Length;
            int numRows = (int)Math.Ceiling(totalSeats / (double)SeatsPerRow);

            using (var conn = DbHelper.GetConnection())
            {
                var insertQuery = "INSERT INTO Aircraft(Name, NumSeats) VALUES (@Name, @NumSeats); Select Cast (SCOPE_IDENTITY() AS INT);";
                int aircraftID = conn.QuerySingle<int>(insertQuery, new { Name = name, numSeats = totalSeats });

                int seatCounter = 0;
                for (int row = 1; row <= numRows && seatCounter < totalSeats; row++)
                {
                    foreach (char col in seatColumns)
                    {
                        if (seatCounter >= totalSeats)
                            break;

                        string seatNumber = $"{col}{row}";
                        conn.Execute("INSERT INTO Seat (AircraftID, SeatNumber) VALUES (@AircraftID, @SeatNumber)",
                            new { AircraftID = aircraftID, SeatNumber = seatNumber });

                        seatCounter++;
                    }
                }

            }
            LoadAircraft();
            txtName.Clear();
            numSeats.Value = 0;


        }

        private void LoadAircraft()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var list = conn.Query<Aircraft>("Select * From Aircraft").ToList();
               dgvAircraft.DataSource = list;
            }

        }

        private void AircraftForm_Load(object sender, EventArgs e)
        {
            LoadAircraft();
        }

        private void btnDeleteAircraft_Click(object sender, EventArgs e)
        {
            if (dgvAircraft.CurrentRow == null) return;

            var aircraft = (Aircraft)dgvAircraft.CurrentRow.DataBoundItem;

            using (var conn = DbHelper.GetConnection())
            {
                conn.Execute("DELETE FROM Seat WHERE AircraftID = @ID", new { ID = aircraft.AircraftID });

                conn.Execute("DELETE FROM Aircraft WHERE AircraftID = @ID", new {ID = aircraft.AircraftID});

            }

            LoadAircraft();
        }
    }
}

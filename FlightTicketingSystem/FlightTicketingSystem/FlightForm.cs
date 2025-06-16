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
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }
    

    private void LoadAircrafts()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var list = conn.Query<Aircraft>("SELECT * FROM Aircraft").ToList();
                cmbAircraft.DataSource = list;
                cmbAircraft.DisplayMember = "Name";
                cmbAircraft.ValueMember = "AircraftID";
            }

        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            LoadAircrafts();
            LoadFlights();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            int aircraftId = (int)cmbAircraft.SelectedValue; //changed for 7.5
            string origin = txtOrigin.Text.Trim();
            string destination =txtDestination.Text.Trim();
            string flightNo = txtFlightNumber.Text.Trim(); // added for 7.5

            DateTime date = dtpFlightDate.Value.Date;
            DateTime time = dtpFlightTime.Value;
            DateTime departure = date.Add(time.TimeOfDay);

            using (var conn = DbHelper.GetConnection())
            {
                conn.Execute(@"INSERT INTO Flight (AircraftID, Departure, Arrival, DepartureTime, FlightNumber) 
                            Values (@AircraftID, @Departure, @Arrival, @DepartureTime, @FlightNumber)", 
                            //changed Origin = origin to Departure = origin && Destination = destination to Arrival = destination
                            new { AircraftID = aircraftId, 
                                Departure = origin, 
                                Arrival = destination, 
                                DepartureTime = departure,
                                FlightNumber = flightNo});

            }
            LoadFlights();
            txtFlightNumber.Clear();
            txtOrigin.Clear();
            txtDestination.Clear();



            }

        private void LoadFlights()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var list = conn.Query<Flight>(@"
                    Select f.FlightID, f.AircraftID, a.Name AS AircraftName, f.Departure, f.Arrival, f.DepartureTime, f.FlightNumber
                    FROM Flight f
                    JOIN Aircraft a ON f.AircraftID = a.AircraftID
                    ").ToList();

                dgvFlights.DataSource = list;
            }

        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow == null) return;

            var flight = (Flight)dgvFlights.CurrentRow.DataBoundItem;

            using (var conn = DbHelper.GetConnection())
            {
                conn.Execute("DELETE FROM Flight WHERE FlightID = @ID", new { ID = flight.FlightID });

            }

            LoadFlights();
        }
    }
    }




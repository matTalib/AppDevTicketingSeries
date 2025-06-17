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
    public partial class BookingForm : Form
    {
        int selectedSeatId = -1;

        public BookingForm()
        {
            InitializeComponent();
        }


        private void LoadFlights()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var flights = conn.Query<Flight>(
                    "SELECT FlightID, FlightNumber FROM Flight").ToList();
                cmbFlight.DataSource = flights;
                cmbFlight.DisplayMember = "FlightNumber";
                cmbFlight.ValueMember = "FlightID";
                cmbFlight.SelectedIndex = -1;
            }

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
            
        }

        private void LoadSeats(int flightId)
        {
            flpSeats.Controls.Clear();

            using (var conn = DbHelper.GetConnection())
            {
                var aircraftId = conn.QuerySingle<int>(
                    "SELECT AircraftID FROM Flight WHERE FlightID = @FlightID", new {FlightID= flightId});

                var seats = conn.Query<Seat>(
                 //   "Select * FROM Seat WHERE AircraftID = @AircraftID", new {AircraftID = aircraftId}).ToList();
                 "SELECT s.* FROM Seat s JOIN Flight f ON s.AircraftID = f.AircraftID WHERE f.FlightID = @FlightID",
                 new { FlightID = flightId }).ToList();

                var bookedSeatIds = conn.Query<int>("Select SeatID FROM Booking WHERE FlightID = @FlightID", new {FlightID = flightId}).ToList();

                foreach (var seat in seats)
                {
                    var btn = new Button
                    {
                        Text = seat.SeatNumber,
                        Width = 50,
                        Height = 50,
                        Margin = new Padding (5),
                        Tag = seat.SeatID,
                        BackColor = bookedSeatIds.Contains(seat.SeatID) ? Color.Gray : Color.LightGreen,
                        Enabled = !bookedSeatIds.Contains(seat.SeatID)

                    };

                    btn.Click += (s, e) =>
                    {
                        foreach (Button b in flpSeats.Controls) b.BackColor = Color.LightGreen;
                        btn.BackColor = Color.Orange;
                        selectedSeatId = (int)btn.Tag;
                    };
                    flpSeats.Controls.Add(btn);
                }
            }
        }

        private void cmbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFlight.SelectedValue != null && cmbFlight.SelectedValue is int flightId)
            {
                LoadSeats(flightId);
            }

        }

        private void btnBookSeat_Click(object sender, EventArgs e)
        {
            if (cmbFlight.SelectedValue == null || selectedSeatId == -1 || string.IsNullOrWhiteSpace(txtPassengerName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
                    {
                MessageBox.Show("Please complete all fields and select a seat.");
                    return;

            }

            var fullName = txtPassengerName.Text.Trim();
            var contact = txtContact.Text.Trim();
            var flightId = (int)cmbFlight.SelectedValue;

            using (var conn = DbHelper.GetConnection())
            {
                int passengerId = conn.ExecuteScalar<int>(
                    @"INSERT INTO Passenger ( FullName, Contact)
                    OUTPUT INSERTED.PassengerID
                    VALUES (@FullName, @Contact)",
                    new { FullName = fullName, Contact = contact });

                conn.Execute(
                "INSERT INTO Booking (FlightID, SeatID, PassengerID) VALUES (@FlightID, @SeatID, @PassengerID)", // changed @SeeatID  to @SeatID in 8.5
                new { FlightID = flightId, SeatID = selectedSeatId, PassengerID = passengerId });

                conn.Execute("UPDATE Seat SET IsBooked = 1 WHERE SeatID = @SeatID", new { SeatID = selectedSeatId });
            }
            MessageBox.Show("Booking is successful");
            txtPassengerName.Clear();
            txtContact.Clear();
            selectedSeatId = -1;
            LoadSeats(flightId);
        }


        }
    }




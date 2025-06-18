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
    public partial class ViewBookingForm : Form
    {
        public ViewBookingForm()
        {
            InitializeComponent();
        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
            LoadBookings();

        }

        private void LoadFlights()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var flights = conn.Query<Flight>("Select FlightID, FlightNumber FROM Flight").ToList();
                cmbFilterFlight.DataSource = flights;
                cmbFilterFlight.DisplayMember = "FlightNumber";
                cmbFilterFlight.ValueMember = "FlightID";
                cmbFilterFlight.SelectedIndex = -1;

            }

        }

        private void LoadBookings(int? flightId = null)
        {
            using (var conn = DbHelper.GetConnection())
            {
                string query = @"
                SELECT
                    b.BookingID,
                    b.SeatID,
                    p.FullName AS Passenger,
                    p.Contact,
                    f.FlightNumber,
                    f.Departure,
                    f.Arrival,
                    f.DepartureTime,
                    s.SeatNumber                   
                FROM Booking b
                JOIN Passenger p ON b.PassengerID = p.PassengerID
                JOIN Flight f ON b.FlightID = f.FlightID
                JOIN Seat s ON b.SeatID = s.SeatID
               ";

                if (flightId.HasValue)
                {
                    query += " WHERE b.FlightID = @FlightID";
                }

                var bookings = conn.Query<ViewBooking>(query, new { FlightID = flightId }).ToList();

                dgvBookings.Columns.Clear();
                dgvBookings.DataSource = bookings;

            }

        }

        private void cmbFilterFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterFlight.SelectedItem is Flight selectedFlight)
            {
                int flightId = selectedFlight.FlightID;
                LoadBookings(flightId);
            }
            else
            {
                LoadBookings();
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int bookingId = Convert.ToInt32(dgvBookings.CurrentRow.Cells["BookingID"].Value);
            int seatId = Convert.ToInt32(dgvBookings.CurrentRow.Cells["SeatID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)

                return;

            using (var conn = DbHelper.GetConnection())
            {
                conn.Execute("DELETE FROM Booking Where BookingID = @BookingID", new { BookingID = bookingId });
                conn.Execute("UPDATE Seat SET IsBooked = 0 WHERE SeatID = @SeatID", new { SeatID = seatId });

            }
            MessageBox.Show("Booking deleted successfully.");

            if (cmbFilterFlight.SelectedItem is Flight selectedFlight)
            {
                LoadBookings(selectedFlight.FlightID);
            }
            else
            {
                LoadBookings();
            }


        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            var booking = dgvBookings.CurrentRow.DataBoundItem as ViewBooking;

            if (booking == null)
            {
                MessageBox.Show("Could not load booking data.");
                return;
            }

            //creating a 500 x 300 pixel image
            using (Bitmap bmp = new Bitmap(500, 300))
            using (Graphics g = Graphics.FromImage(bmp)) // create a graphics object to draw on image
            {

                Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold); //title font
                Font bodyFont = new Font("Segoe UI", 12); // body of font

                g.Clear(Color.White);
                //draws all the information based on each line
                g.DrawString("FLIGHT TICKET", titleFont, Brushes.Black, new PointF(150, 20));
                g.DrawString($"Passenger: {booking.Passenger}", bodyFont, Brushes.Black, 30, 70);
                g.DrawString($"Contact: {booking.Contact}", bodyFont, Brushes.Black, 30, 100);
                g.DrawString($"Flight No: {booking.FlightNumber}", bodyFont, Brushes.Black, 30, 120);
                g.DrawString($"From: {booking.Departure} To: {booking.Arrival}", bodyFont, Brushes.Black, 30, 160);
                g.DrawString($"Seat: {booking.SeatNumber}", bodyFont, Brushes.Black, 30, 180);
                g.DrawString($"Departure: {booking.DepartureTime:f}", bodyFont, Brushes.Black, 30, 210);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png";
                    sfd.Title = "Save Ticket As Image";
                    sfd.FileName = "Ticket.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(sfd.FileName);
                        MessageBox.Show("Ticket saved successfully.");
                    }

                }
            }
        }
    }
}


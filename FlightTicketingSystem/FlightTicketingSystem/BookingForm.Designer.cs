namespace FlightTicketingSystem
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFlight = new System.Windows.Forms.Label();
            this.cmbFlight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSeats = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnBookSeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(167, 108);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(123, 28);
            this.lblFlight.TabIndex = 0;
            this.lblFlight.Text = "Select Flight:";
            // 
            // cmbFlight
            // 
            this.cmbFlight.FormattingEnabled = true;
            this.cmbFlight.Location = new System.Drawing.Point(383, 108);
            this.cmbFlight.Name = "cmbFlight";
            this.cmbFlight.Size = new System.Drawing.Size(301, 36);
            this.cmbFlight.TabIndex = 1;
            this.cmbFlight.SelectedIndexChanged += new System.EventHandler(this.cmbFlight_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flights:";
            // 
            // flpSeats
            // 
            this.flpSeats.AutoScroll = true;
            this.flpSeats.Location = new System.Drawing.Point(282, 255);
            this.flpSeats.Name = "flpSeats";
            this.flpSeats.Size = new System.Drawing.Size(402, 132);
            this.flpSeats.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passenger Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact:";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(439, 437);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(245, 34);
            this.txtPassengerName.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(439, 504);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(245, 34);
            this.txtContact.TabIndex = 7;
            // 
            // btnBookSeat
            // 
            this.btnBookSeat.Location = new System.Drawing.Point(562, 566);
            this.btnBookSeat.Name = "btnBookSeat";
            this.btnBookSeat.Size = new System.Drawing.Size(122, 52);
            this.btnBookSeat.TabIndex = 8;
            this.btnBookSeat.Text = "Book Seat";
            this.btnBookSeat.UseVisualStyleBackColor = true;
            this.btnBookSeat.Click += new System.EventHandler(this.btnBookSeat_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.btnBookSeat);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpSeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFlight);
            this.Controls.Add(this.lblFlight);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.ComboBox cmbFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnBookSeat;
    }
}
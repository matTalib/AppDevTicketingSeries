namespace FlightTicketingSystem
{
    partial class FlightForm
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
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFlightDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAircraft = new System.Windows.Forms.ComboBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFlightTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Location = new System.Drawing.Point(213, 83);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(143, 28);
            this.lblFlightNumber.TabIndex = 0;
            this.lblFlightNumber.Text = "Flight Number:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(189, 152);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(167, 28);
            this.lblDeparture.TabIndex = 1;
            this.lblDeparture.Text = "From (Departure):";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(430, 83);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(254, 34);
            this.txtFlightNumber.TabIndex = 2;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(246, 225);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(110, 28);
            this.lblArrival.TabIndex = 3;
            this.lblArrival.Text = "To (Arrival):";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(430, 149);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(254, 34);
            this.txtOrigin.TabIndex = 4;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(430, 222);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(254, 34);
            this.txtDestination.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // dtpFlightDate
            // 
            this.dtpFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFlightDate.Location = new System.Drawing.Point(430, 293);
            this.dtpFlightDate.Name = "dtpFlightDate";
            this.dtpFlightDate.Size = new System.Drawing.Size(254, 34);
            this.dtpFlightDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aircraft:";
            // 
            // cmbAircraft
            // 
            this.cmbAircraft.FormattingEnabled = true;
            this.cmbAircraft.Location = new System.Drawing.Point(430, 429);
            this.cmbAircraft.Name = "cmbAircraft";
            this.cmbAircraft.Size = new System.Drawing.Size(254, 36);
            this.cmbAircraft.TabIndex = 9;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(525, 501);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(159, 51);
            this.btnAddFlight.TabIndex = 10;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFlights.Location = new System.Drawing.Point(0, 731);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 62;
            this.dgvFlights.RowTemplate.Height = 28;
            this.dgvFlights.Size = new System.Drawing.Size(952, 99);
            this.dgvFlights.TabIndex = 11;
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Location = new System.Drawing.Point(525, 680);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(159, 51);
            this.btnDeleteFlight.TabIndex = 12;
            this.btnDeleteFlight.Text = "Delete Flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Time:";
            // 
            // dtpFlightTime
            // 
            this.dtpFlightTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFlightTime.Location = new System.Drawing.Point(430, 361);
            this.dtpFlightTime.Name = "dtpFlightTime";
            this.dtpFlightTime.Size = new System.Drawing.Size(254, 34);
            this.dtpFlightTime.TabIndex = 14;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 811);
            this.Controls.Add(this.dtpFlightTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.cmbAircraft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFlightDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblFlightNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFlightDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAircraft;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFlightTime;
    }
}
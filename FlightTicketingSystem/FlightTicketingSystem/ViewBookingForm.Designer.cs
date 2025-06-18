namespace FlightTicketingSystem
{
    partial class ViewBookingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilterFlight = new System.Windows.Forms.ComboBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by Flight:";
            // 
            // cmbFilterFlight
            // 
            this.cmbFilterFlight.FormattingEnabled = true;
            this.cmbFilterFlight.Location = new System.Drawing.Point(453, 149);
            this.cmbFilterFlight.Name = "cmbFilterFlight";
            this.cmbFilterFlight.Size = new System.Drawing.Size(383, 36);
            this.cmbFilterFlight.TabIndex = 1;
            this.cmbFilterFlight.SelectedIndexChanged += new System.EventHandler(this.cmbFilterFlight_SelectedIndexChanged);
            // 
            // dgvBookings
            // 
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(81, 236);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 62;
            this.dgvBookings.RowTemplate.Height = 28;
            this.dgvBookings.Size = new System.Drawing.Size(755, 150);
            this.dgvBookings.TabIndex = 2;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(81, 459);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(180, 46);
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(656, 459);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(180, 46);
            this.btnCreateTicket.TabIndex = 4;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // ViewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.cmbFilterFlight);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBookingForm";
            this.Text = "ViewBookingForm";
            this.Load += new System.EventHandler(this.ViewBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilterFlight;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnCreateTicket;
    }
}
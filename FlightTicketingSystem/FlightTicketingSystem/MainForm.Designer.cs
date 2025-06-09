namespace FlightTicketingSystem
{
    partial class MainForm
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
            this.btnAircraft = new System.Windows.Forms.Button();
            this.btnFlight = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Ticketing System";
            // 
            // btnAircraft
            // 
            this.btnAircraft.Location = new System.Drawing.Point(55, 127);
            this.btnAircraft.Name = "btnAircraft";
            this.btnAircraft.Size = new System.Drawing.Size(190, 79);
            this.btnAircraft.TabIndex = 1;
            this.btnAircraft.Text = "Manage Aircraft";
            this.btnAircraft.UseVisualStyleBackColor = true;
            this.btnAircraft.Click += new System.EventHandler(this.btnAircraft_Click);
            // 
            // btnFlight
            // 
            this.btnFlight.Location = new System.Drawing.Point(380, 127);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(190, 79);
            this.btnFlight.TabIndex = 2;
            this.btnFlight.Text = "Manage Flights";
            this.btnFlight.UseVisualStyleBackColor = true;
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(705, 127);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(190, 79);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book Seats";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(55, 292);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(190, 79);
            this.btnViewBook.TabIndex = 4;
            this.btnViewBook.Text = "View Bookings";
            this.btnViewBook.UseVisualStyleBackColor = true;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(380, 292);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 79);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 631);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnFlight);
            this.Controls.Add(this.btnAircraft);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAircraft;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnLogout;
    }
}


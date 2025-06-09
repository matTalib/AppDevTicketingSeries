namespace FlightTicketingSystem
{
    partial class AircraftForm
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
            this.lblAircraft = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.btnAddAicraft = new System.Windows.Forms.Button();
            this.dgvAircraft = new System.Windows.Forms.DataGridView();
            this.btnDeleteAircraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Location = new System.Drawing.Point(44, 29);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(127, 28);
            this.lblAircraft.TabIndex = 0;
            this.lblAircraft.Text = "Aircraft Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(399, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Aircraft Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(620, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 34);
            this.txtName.TabIndex = 2;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(399, 194);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(162, 28);
            this.lblSeats.TabIndex = 3;
            this.lblSeats.Text = "Number of Seats:";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(753, 194);
            this.numSeats.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(120, 34);
            this.numSeats.TabIndex = 4;
            // 
            // btnAddAicraft
            // 
            this.btnAddAicraft.Location = new System.Drawing.Point(707, 277);
            this.btnAddAicraft.Name = "btnAddAicraft";
            this.btnAddAicraft.Size = new System.Drawing.Size(166, 56);
            this.btnAddAicraft.TabIndex = 5;
            this.btnAddAicraft.Text = "Add Aircraft";
            this.btnAddAicraft.UseVisualStyleBackColor = true;
            this.btnAddAicraft.Click += new System.EventHandler(this.btnAddAicraft_Click);
            // 
            // dgvAircraft
            // 
            this.dgvAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAircraft.Location = new System.Drawing.Point(49, 395);
            this.dgvAircraft.Name = "dgvAircraft";
            this.dgvAircraft.RowHeadersWidth = 62;
            this.dgvAircraft.RowTemplate.Height = 28;
            this.dgvAircraft.Size = new System.Drawing.Size(824, 71);
            this.dgvAircraft.TabIndex = 6;
            // 
            // btnDeleteAircraft
            // 
            this.btnDeleteAircraft.Location = new System.Drawing.Point(707, 514);
            this.btnDeleteAircraft.Name = "btnDeleteAircraft";
            this.btnDeleteAircraft.Size = new System.Drawing.Size(166, 56);
            this.btnDeleteAircraft.TabIndex = 7;
            this.btnDeleteAircraft.Text = "Delete Aircraft";
            this.btnDeleteAircraft.UseVisualStyleBackColor = true;
            this.btnDeleteAircraft.Click += new System.EventHandler(this.btnDeleteAircraft_Click);
            // 
            // AircraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.btnDeleteAircraft);
            this.Controls.Add(this.dgvAircraft);
            this.Controls.Add(this.btnAddAicraft);
            this.Controls.Add(this.numSeats);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAircraft);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AircraftForm";
            this.Text = "AircraftForm";
            this.Load += new System.EventHandler(this.AircraftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircraft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.Button btnAddAicraft;
        private System.Windows.Forms.DataGridView dgvAircraft;
        private System.Windows.Forms.Button btnDeleteAircraft;
    }
}
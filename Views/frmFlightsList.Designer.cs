namespace frmAeropuerto.Views
{
    partial class frmFlightsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlightsList));
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstOutFlights = new System.Windows.Forms.ListBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestiny = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 63);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Borrar Vuelo Saliente";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstOutFlights
            // 
            this.lstOutFlights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOutFlights.FormattingEnabled = true;
            this.lstOutFlights.HorizontalScrollbar = true;
            this.lstOutFlights.ItemHeight = 15;
            this.lstOutFlights.Location = new System.Drawing.Point(132, 68);
            this.lstOutFlights.Name = "lstOutFlights";
            this.lstOutFlights.Size = new System.Drawing.Size(525, 319);
            this.lstOutFlights.TabIndex = 5;
            this.lstOutFlights.SelectedIndexChanged += new System.EventHandler(this.lstOutFlights_SelectedIndexChanged);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(782, 34);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(100, 25);
            this.txtOrigin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ciudad de origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciudad de destino:";
            // 
            // txtDestiny
            // 
            this.txtDestiny.Location = new System.Drawing.Point(782, 65);
            this.txtDestiny.Name = "txtDestiny";
            this.txtDestiny.Size = new System.Drawing.Size(100, 25);
            this.txtDestiny.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(682, 125);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 25);
            this.dtpDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de vuelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hora de partida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hora de llegada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "HH-MM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(818, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "HH-MM";
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(782, 250);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(100, 25);
            this.txtAirline.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Aerolínea:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(782, 284);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 25);
            this.txtState.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Estado del vuelo:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(668, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 63);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Guardar Información";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(666, 187);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(110, 25);
            this.dtpDepartureTime.TabIndex = 27;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(782, 187);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(110, 25);
            this.dtpArrivalTime.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(152, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(497, 51);
            this.label10.TabIndex = 29;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // frmFlightsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 407);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAirline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDestiny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lstOutFlights);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmFlightsList";
            this.Text = "Vuelos Salientes";
            this.Load += new System.EventHandler(this.frmFlightsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelete;
        private ListBox lstOutFlights;
        private TextBox txtOrigin;
        private Label label1;
        private Label label2;
        private TextBox txtDestiny;
        private DateTimePicker dtpDate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAirline;
        private Label label8;
        private TextBox txtState;
        private Label label9;
        private Button btnSave;
        private DateTimePicker dtpDepartureTime;
        private DateTimePicker dtpArrivalTime;
        private Label label10;
    }
}
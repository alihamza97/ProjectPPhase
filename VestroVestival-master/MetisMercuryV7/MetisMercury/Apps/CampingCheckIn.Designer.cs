namespace MetisMercury.Apps
{
    partial class CampingCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampingCheckIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbGreetings = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tbspotID = new System.Windows.Forms.TextBox();
            this.lbday = new System.Windows.Forms.Label();
            this.lbRFIDStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(177, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 23);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "Camping CheckIn ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lbday);
            this.panel1.Controls.Add(this.lbRFIDStatus);
            this.panel1.Controls.Add(this.lbWarning);
            this.panel1.Controls.Add(this.lbGreetings);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.tbspotID);
            this.panel1.Location = new System.Drawing.Point(17, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 165);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWarning.Location = new System.Drawing.Point(20, 81);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(55, 15);
            this.lbWarning.TabIndex = 26;
            this.lbWarning.Text = "Warning";
            // 
            // lbGreetings
            // 
            this.lbGreetings.AutoSize = true;
            this.lbGreetings.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbGreetings.Location = new System.Drawing.Point(20, 52);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(52, 15);
            this.lbGreetings.TabIndex = 25;
            this.lbGreetings.Text = "Greeting";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcess.Location = new System.Drawing.Point(58, 10);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 21);
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tbspotID
            // 
            this.tbspotID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbspotID.Location = new System.Drawing.Point(12, 10);
            this.tbspotID.Name = "tbspotID";
            this.tbspotID.Size = new System.Drawing.Size(40, 23);
            this.tbspotID.TabIndex = 23;
            // 
            // lbday
            // 
            this.lbday.AutoSize = true;
            this.lbday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbday.Location = new System.Drawing.Point(21, 119);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(105, 15);
            this.lbday.TabIndex = 28;
            this.lbday.Text = "ReservationStatus";
            this.lbday.Click += new System.EventHandler(this.lbday_Click);
            // 
            // lbRFIDStatus
            // 
            this.lbRFIDStatus.AutoSize = true;
            this.lbRFIDStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFIDStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRFIDStatus.Location = new System.Drawing.Point(153, 14);
            this.lbRFIDStatus.Name = "lbRFIDStatus";
            this.lbRFIDStatus.Size = new System.Drawing.Size(41, 15);
            this.lbRFIDStatus.TabIndex = 27;
            this.lbRFIDStatus.Text = "Status";
            // 
            // CampingCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CampingCheckIn";
            this.Text = "CampingCheckIn";
            this.Load += new System.EventHandler(this.CampingCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbGreetings;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox tbspotID;
        private System.Windows.Forms.Label lbday;
        private System.Windows.Forms.Label lbRFIDStatus;
    }
}
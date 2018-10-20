namespace MetisMercury.Apps
{
    partial class Exit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.label22 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEventID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEquipment = new System.Windows.Forms.Label();
            this.lbRemainingBlnc = new System.Windows.Forms.Label();
            this.totalVisitors = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lbWarnings = new System.Windows.Forms.Label();
            this.lbTotalPresentParticipants = new System.Windows.Forms.Label();
            this.lbTotalParticipants = new System.Windows.Forms.Label();
            this.lbRFIDStatus = new System.Windows.Forms.Label();
            this.lbRemainingBalance = new System.Windows.Forms.Label();
            this.lbEquipmentReturn = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(191, 33);
            this.label22.TabIndex = 7;
            this.label22.Text = "CheckOutStatus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.lbEventID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbEquipment);
            this.panel2.Controls.Add(this.lbRemainingBlnc);
            this.panel2.Controls.Add(this.totalVisitors);
            this.panel2.Controls.Add(this.btnSignOut);
            this.panel2.Controls.Add(this.lbWarnings);
            this.panel2.Controls.Add(this.lbTotalPresentParticipants);
            this.panel2.Controls.Add(this.lbTotalParticipants);
            this.panel2.Controls.Add(this.lbRFIDStatus);
            this.panel2.Controls.Add(this.lbRemainingBalance);
            this.panel2.Controls.Add(this.lbEquipmentReturn);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 141);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(337, 18);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(21, 19);
            this.lbEventID.TabIndex = 17;
            this.lbEventID.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Event ID:";
            // 
            // lbEquipment
            // 
            this.lbEquipment.AutoSize = true;
            this.lbEquipment.Location = new System.Drawing.Point(179, 99);
            this.lbEquipment.Name = "lbEquipment";
            this.lbEquipment.Size = new System.Drawing.Size(52, 18);
            this.lbEquipment.TabIndex = 15;
            this.lbEquipment.Text = "...........";
            // 
            // lbRemainingBlnc
            // 
            this.lbRemainingBlnc.AutoSize = true;
            this.lbRemainingBlnc.Location = new System.Drawing.Point(179, 81);
            this.lbRemainingBlnc.Name = "lbRemainingBlnc";
            this.lbRemainingBlnc.Size = new System.Drawing.Size(52, 18);
            this.lbRemainingBlnc.TabIndex = 14;
            this.lbRemainingBlnc.Text = "...........";
            // 
            // totalVisitors
            // 
            this.totalVisitors.AutoSize = true;
            this.totalVisitors.Location = new System.Drawing.Point(179, 19);
            this.totalVisitors.Name = "totalVisitors";
            this.totalVisitors.Size = new System.Drawing.Size(52, 18);
            this.totalVisitors.TabIndex = 13;
            this.totalVisitors.Text = "...........";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(475, 85);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(121, 47);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "CheckOut";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lbWarnings
            // 
            this.lbWarnings.AutoSize = true;
            this.lbWarnings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnings.Location = new System.Drawing.Point(390, 30);
            this.lbWarnings.Name = "lbWarnings";
            this.lbWarnings.Size = new System.Drawing.Size(66, 18);
            this.lbWarnings.TabIndex = 11;
            this.lbWarnings.Text = "Warnings";
            this.lbWarnings.Click += new System.EventHandler(this.lbWarnings_Click);
            // 
            // lbTotalPresentParticipants
            // 
            this.lbTotalPresentParticipants.AutoSize = true;
            this.lbTotalPresentParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPresentParticipants.Location = new System.Drawing.Point(180, 19);
            this.lbTotalPresentParticipants.Name = "lbTotalPresentParticipants";
            this.lbTotalPresentParticipants.Size = new System.Drawing.Size(0, 13);
            this.lbTotalPresentParticipants.TabIndex = 10;
            // 
            // lbTotalParticipants
            // 
            this.lbTotalParticipants.AutoSize = true;
            this.lbTotalParticipants.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalParticipants.Location = new System.Drawing.Point(4, 19);
            this.lbTotalParticipants.Name = "lbTotalParticipants";
            this.lbTotalParticipants.Size = new System.Drawing.Size(169, 18);
            this.lbTotalParticipants.TabIndex = 9;
            this.lbTotalParticipants.Text = "Total present participants:";
            this.lbTotalParticipants.Click += new System.EventHandler(this.lbTotalParticipants_Click);
            // 
            // lbRFIDStatus
            // 
            this.lbRFIDStatus.AutoSize = true;
            this.lbRFIDStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFIDStatus.Location = new System.Drawing.Point(390, 12);
            this.lbRFIDStatus.Name = "lbRFIDStatus";
            this.lbRFIDStatus.Size = new System.Drawing.Size(77, 18);
            this.lbRFIDStatus.TabIndex = 8;
            this.lbRFIDStatus.Text = "RFID Status";
            this.lbRFIDStatus.Click += new System.EventHandler(this.lbRFIDStatus_Click);
            // 
            // lbRemainingBalance
            // 
            this.lbRemainingBalance.AutoSize = true;
            this.lbRemainingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemainingBalance.Location = new System.Drawing.Point(143, 74);
            this.lbRemainingBalance.Name = "lbRemainingBalance";
            this.lbRemainingBalance.Size = new System.Drawing.Size(0, 13);
            this.lbRemainingBalance.TabIndex = 7;
            // 
            // lbEquipmentReturn
            // 
            this.lbEquipmentReturn.AutoSize = true;
            this.lbEquipmentReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipmentReturn.Location = new System.Drawing.Point(169, 99);
            this.lbEquipmentReturn.Name = "lbEquipmentReturn";
            this.lbEquipmentReturn.Size = new System.Drawing.Size(0, 13);
            this.lbEquipmentReturn.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "Equipment return status:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Remaining balance:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 197);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel2);
            this.Name = "Exit";
            this.Text = "Exit";
            this.Load += new System.EventHandler(this.Exit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbWarnings;
        private System.Windows.Forms.Label lbTotalPresentParticipants;
        private System.Windows.Forms.Label lbTotalParticipants;
        private System.Windows.Forms.Label lbRFIDStatus;
        private System.Windows.Forms.Label lbRemainingBalance;
        private System.Windows.Forms.Label lbEquipmentReturn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label totalVisitors;
        private System.Windows.Forms.Label lbEquipment;
        private System.Windows.Forms.Label lbRemainingBlnc;
        private System.Windows.Forms.Label lbEventID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
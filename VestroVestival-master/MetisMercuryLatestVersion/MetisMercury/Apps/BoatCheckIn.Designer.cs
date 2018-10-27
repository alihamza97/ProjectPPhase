namespace MetisMercury.Apps
{
    partial class BoatCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoatCheckIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbend = new System.Windows.Forms.Label();
            this.lbstart = new System.Windows.Forms.Label();
            this.lbDAY = new System.Windows.Forms.Label();
            this.lbRFIDStatus = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbGreetings = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tbspotID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(227, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 26);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "BoatCheckIn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lbend);
            this.panel1.Controls.Add(this.lbstart);
            this.panel1.Controls.Add(this.lbDAY);
            this.panel1.Controls.Add(this.lbRFIDStatus);
            this.panel1.Controls.Add(this.lbWarning);
            this.panel1.Controls.Add(this.lbGreetings);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.tbspotID);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 269);
            this.panel1.TabIndex = 39;
            // 
            // lbend
            // 
            this.lbend.AutoSize = true;
            this.lbend.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbend.Location = new System.Drawing.Point(23, 214);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(37, 15);
            this.lbend.TabIndex = 30;
            this.lbend.Text = "Untill";
            // 
            // lbstart
            // 
            this.lbstart.AutoSize = true;
            this.lbstart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbstart.Location = new System.Drawing.Point(23, 172);
            this.lbstart.Name = "lbstart";
            this.lbstart.Size = new System.Drawing.Size(35, 15);
            this.lbstart.TabIndex = 29;
            this.lbstart.Text = "From";
            // 
            // lbDAY
            // 
            this.lbDAY.AutoSize = true;
            this.lbDAY.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDAY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDAY.Location = new System.Drawing.Point(23, 128);
            this.lbDAY.Name = "lbDAY";
            this.lbDAY.Size = new System.Drawing.Size(28, 15);
            this.lbDAY.TabIndex = 28;
            this.lbDAY.Text = "Day";
            // 
            // lbRFIDStatus
            // 
            this.lbRFIDStatus.AutoSize = true;
            this.lbRFIDStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFIDStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRFIDStatus.Location = new System.Drawing.Point(153, 22);
            this.lbRFIDStatus.Name = "lbRFIDStatus";
            this.lbRFIDStatus.Size = new System.Drawing.Size(66, 15);
            this.lbRFIDStatus.TabIndex = 27;
            this.lbRFIDStatus.Text = "RFIDStatus";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWarning.Location = new System.Drawing.Point(23, 96);
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
            this.lbGreetings.Location = new System.Drawing.Point(23, 63);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(52, 15);
            this.lbGreetings.TabIndex = 25;
            this.lbGreetings.Text = "Greeting";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcess.Location = new System.Drawing.Point(72, 10);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 39);
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tbspotID
            // 
            this.tbspotID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbspotID.Location = new System.Drawing.Point(26, 19);
            this.tbspotID.Name = "tbspotID";
            this.tbspotID.Size = new System.Drawing.Size(40, 23);
            this.tbspotID.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoatCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BoatCheckIn";
            this.Text = "BoatCheckIn";
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
        private System.Windows.Forms.Label lbRFIDStatus;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbGreetings;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox tbspotID;
        private System.Windows.Forms.Label lbDAY;
        private System.Windows.Forms.Label lbend;
        private System.Windows.Forms.Label lbstart;
        private System.Windows.Forms.Button button1;
    }
}
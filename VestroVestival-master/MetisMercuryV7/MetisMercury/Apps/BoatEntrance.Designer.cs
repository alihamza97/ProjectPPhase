namespace MetisMercury.Apps
{
    partial class BoatEntrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoatEntrance));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbReservStatus = new System.Windows.Forms.Label();
            this.lbChekingStatus = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lbRFIDStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(264, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 26);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "BoatEntrance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lbReservStatus);
            this.panel1.Controls.Add(this.lbChekingStatus);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.lbRFIDStatus);
            this.panel1.Location = new System.Drawing.Point(15, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 85);
            this.panel1.TabIndex = 37;
            // 
            // lbReservStatus
            // 
            this.lbReservStatus.AutoSize = true;
            this.lbReservStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservStatus.Location = new System.Drawing.Point(13, 37);
            this.lbReservStatus.Name = "lbReservStatus";
            this.lbReservStatus.Size = new System.Drawing.Size(108, 15);
            this.lbReservStatus.TabIndex = 19;
            this.lbReservStatus.Text = "Reservation status";
            // 
            // lbChekingStatus
            // 
            this.lbChekingStatus.AutoSize = true;
            this.lbChekingStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChekingStatus.Location = new System.Drawing.Point(13, 11);
            this.lbChekingStatus.Name = "lbChekingStatus";
            this.lbChekingStatus.Size = new System.Drawing.Size(93, 15);
            this.lbChekingStatus.TabIndex = 18;
            this.lbChekingStatus.Text = "Checking status";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(303, 11);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 66);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lbRFIDStatus
            // 
            this.lbRFIDStatus.AutoSize = true;
            this.lbRFIDStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFIDStatus.Location = new System.Drawing.Point(13, 62);
            this.lbRFIDStatus.Name = "lbRFIDStatus";
            this.lbRFIDStatus.Size = new System.Drawing.Size(66, 15);
            this.lbRFIDStatus.TabIndex = 17;
            this.lbRFIDStatus.Text = "RFIDStatus";
            // 
            // BoatEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 143);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BoatEntrance";
            this.Text = "BoatEntrance";
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
        private System.Windows.Forms.Label lbReservStatus;
        private System.Windows.Forms.Label lbChekingStatus;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lbRFIDStatus;
    }
}
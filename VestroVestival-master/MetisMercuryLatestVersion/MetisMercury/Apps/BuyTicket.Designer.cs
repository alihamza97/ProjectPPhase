namespace MetisMercury.Apps
{
    partial class BuyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicket));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SUN = new System.Windows.Forms.CheckBox();
            this.SAT = new System.Windows.Forms.CheckBox();
            this.FRI = new System.Windows.Forms.CheckBox();
            this.tbticketType = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBLNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBFNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.TBCUSID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "SignUpAndTicketPoint";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SUN);
            this.panel1.Controls.Add(this.SAT);
            this.panel1.Controls.Add(this.FRI);
            this.panel1.Controls.Add(this.tbticketType);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBLNAME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBFNAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.TBCUSID);
            this.panel1.Location = new System.Drawing.Point(27, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 250);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SUN
            // 
            this.SUN.AutoSize = true;
            this.SUN.Location = new System.Drawing.Point(214, 163);
            this.SUN.Name = "SUN";
            this.SUN.Size = new System.Drawing.Size(49, 17);
            this.SUN.TabIndex = 65;
            this.SUN.Text = "SUN";
            this.SUN.UseVisualStyleBackColor = true;
            // 
            // SAT
            // 
            this.SAT.AutoSize = true;
            this.SAT.Location = new System.Drawing.Point(161, 163);
            this.SAT.Name = "SAT";
            this.SAT.Size = new System.Drawing.Size(47, 17);
            this.SAT.TabIndex = 64;
            this.SAT.Text = "SAT";
            this.SAT.UseVisualStyleBackColor = true;
            // 
            // FRI
            // 
            this.FRI.AutoSize = true;
            this.FRI.Location = new System.Drawing.Point(112, 162);
            this.FRI.Name = "FRI";
            this.FRI.Size = new System.Drawing.Size(43, 17);
            this.FRI.TabIndex = 63;
            this.FRI.Text = "FRI";
            this.FRI.UseVisualStyleBackColor = true;
            // 
            // tbticketType
            // 
            this.tbticketType.BackColor = System.Drawing.Color.Thistle;
            this.tbticketType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbticketType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbticketType.ForeColor = System.Drawing.Color.Thistle;
            this.tbticketType.Location = new System.Drawing.Point(112, 186);
            this.tbticketType.Name = "tbticketType";
            this.tbticketType.ReadOnly = true;
            this.tbticketType.Size = new System.Drawing.Size(72, 16);
            this.tbticketType.TabIndex = 61;
            this.tbticketType.Visible = false;
            this.tbticketType.TextChanged += new System.EventHandler(this.tbticketType_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(14, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 19);
            this.label18.TabIndex = 62;
            this.label18.Text = "TicketType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(112, 118);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(72, 23);
            this.tbemail.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "LastName:";
            // 
            // TBLNAME
            // 
            this.TBLNAME.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLNAME.Location = new System.Drawing.Point(112, 86);
            this.TBLNAME.Name = "TBLNAME";
            this.TBLNAME.Size = new System.Drawing.Size(72, 23);
            this.TBLNAME.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "FirstName:";
            // 
            // TBFNAME
            // 
            this.TBFNAME.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFNAME.Location = new System.Drawing.Point(112, 42);
            this.TBFNAME.Name = "TBFNAME";
            this.TBFNAME.Size = new System.Drawing.Size(72, 23);
            this.TBFNAME.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "CustomerID:";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcess.Location = new System.Drawing.Point(314, 87);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(86, 51);
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // TBCUSID
            // 
            this.TBCUSID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBCUSID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCUSID.Location = new System.Drawing.Point(112, 6);
            this.TBCUSID.Name = "TBCUSID";
            this.TBCUSID.ReadOnly = true;
            this.TBCUSID.Size = new System.Drawing.Size(72, 23);
            this.TBCUSID.TabIndex = 23;
            this.TBCUSID.TextChanged += new System.EventHandler(this.TBCUSID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 23);
            this.textBox1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Add Balance";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 351);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox TBCUSID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBLNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBFNAME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbticketType;
        private System.Windows.Forms.CheckBox SUN;
        private System.Windows.Forms.CheckBox SAT;
        private System.Windows.Forms.CheckBox FRI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
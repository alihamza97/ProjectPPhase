namespace MetisMercury.Apps
{
    partial class EquipmentShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentShop));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCurrentBalance = new System.Windows.Forms.Label();
            this.lbEventID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClearItem = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridVisitor = new System.Windows.Forms.DataGridView();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbBalance);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbTotalPrice);
            this.panel2.Location = new System.Drawing.Point(9, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 74);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbCurrentBalance
            // 
            this.lbCurrentBalance.AutoSize = true;
            this.lbCurrentBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentBalance.Location = new System.Drawing.Point(254, 35);
            this.lbCurrentBalance.Name = "lbCurrentBalance";
            this.lbCurrentBalance.Size = new System.Drawing.Size(29, 19);
            this.lbCurrentBalance.TabIndex = 13;
            this.lbCurrentBalance.Text = "0.0";
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(107, 35);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(29, 19);
            this.lbEventID.TabIndex = 10;
            this.lbEventID.Text = ".....";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(182, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 7;
            this.label14.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer ID:";
            // 
            // buttonClearItem
            // 
            this.buttonClearItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearItem.Location = new System.Drawing.Point(289, 57);
            this.buttonClearItem.Name = "buttonClearItem";
            this.buttonClearItem.Size = new System.Drawing.Size(127, 30);
            this.buttonClearItem.TabIndex = 33;
            this.buttonClearItem.Text = "Clear Item";
            this.buttonClearItem.UseVisualStyleBackColor = true;
            this.buttonClearItem.Click += new System.EventHandler(this.buttonClearItem_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(289, 93);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(127, 30);
            this.buttonClearAll.TabIndex = 32;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(221, 36);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(40, 26);
            this.lbBalance.TabIndex = 31;
            this.lbBalance.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Remaining Balance:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(221, 10);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(40, 26);
            this.lbTotalPrice.TabIndex = 29;
            this.lbTotalPrice.Text = "0.0";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(289, 303);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(127, 78);
            this.buttonConfirm.TabIndex = 28;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(289, 129);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(127, 88);
            this.buttonReturn.TabIndex = 27;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(108, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 26);
            this.label17.TabIndex = 26;
            this.label17.Text = "Total price:";
            // 
            // dataGridVisitor
            // 
            this.dataGridVisitor.AllowUserToAddRows = false;
            this.dataGridVisitor.AllowUserToDeleteRows = false;
            this.dataGridVisitor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentName,
            this.EquipmentPrice});
            this.dataGridVisitor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridVisitor.Location = new System.Drawing.Point(9, 57);
            this.dataGridVisitor.Name = "dataGridVisitor";
            this.dataGridVisitor.ReadOnly = true;
            this.dataGridVisitor.Size = new System.Drawing.Size(274, 160);
            this.dataGridVisitor.TabIndex = 25;
            // 
            // EquipmentName
            // 
            this.EquipmentName.HeaderText = "Equipment Name";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            this.EquipmentName.Width = 115;
            // 
            // EquipmentPrice
            // 
            this.EquipmentPrice.HeaderText = "Equipment Price";
            this.EquipmentPrice.Name = "EquipmentPrice";
            this.EquipmentPrice.ReadOnly = true;
            this.EquipmentPrice.Width = 115;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(152, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "USB";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(9, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "USBCable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Camera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Charger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "VerstroVestival Equipment Rent";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EquipmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 393);
            this.Controls.Add(this.lbCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbEventID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonClearItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridVisitor);
            this.Name = "EquipmentShop";
            this.Text = "EquipmentShop";
            this.Load += new System.EventHandler(this.EquipmentShop_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCurrentBalance;
        private System.Windows.Forms.Label lbEventID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClearItem;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentPrice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
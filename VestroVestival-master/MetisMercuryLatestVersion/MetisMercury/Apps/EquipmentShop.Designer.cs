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
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbCurrentBalance = new System.Windows.Forms.Label();
            this.lbEventID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClearItem = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dataGridVisitor = new System.Windows.Forms.DataGridView();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usb5 = new System.Windows.Forms.Button();
            this.cable9 = new System.Windows.Forms.Button();
            this.camera13 = new System.Windows.Forms.Button();
            this.charger1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbuserid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chargerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Charger4 = new System.Windows.Forms.Button();
            this.Charger3 = new System.Windows.Forms.Button();
            this.Charger2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.USB8 = new System.Windows.Forms.Button();
            this.USB7 = new System.Windows.Forms.Button();
            this.usb6 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CABLE12 = new System.Windows.Forms.Button();
            this.CABLE10 = new System.Windows.Forms.Button();
            this.CABLE11 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CAMERA16 = new System.Windows.Forms.Button();
            this.CAMERA15 = new System.Windows.Forms.Button();
            this.CAMERA14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.print = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.chargerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbTotalPrice);
            this.panel2.Location = new System.Drawing.Point(9, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 47);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 26);
            this.label17.TabIndex = 26;
            this.label17.Text = "Total price:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(121, 9);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(40, 26);
            this.lbTotalPrice.TabIndex = 29;
            this.lbTotalPrice.Text = "0.0";
            // 
            // lbCurrentBalance
            // 
            this.lbCurrentBalance.AutoSize = true;
            this.lbCurrentBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentBalance.Location = new System.Drawing.Point(230, 35);
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
            this.lbEventID.Click += new System.EventHandler(this.lbEventID_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(158, 35);
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
            this.buttonClearItem.Location = new System.Drawing.Point(162, 287);
            this.buttonClearItem.Name = "buttonClearItem";
            this.buttonClearItem.Size = new System.Drawing.Size(62, 30);
            this.buttonClearItem.TabIndex = 33;
            this.buttonClearItem.Text = "Clear Item";
            this.buttonClearItem.UseVisualStyleBackColor = true;
            this.buttonClearItem.Click += new System.EventHandler(this.buttonClearItem_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(79, 286);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(73, 30);
            this.buttonClearAll.TabIndex = 32;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(343, 239);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(247, 31);
            this.buttonConfirm.TabIndex = 28;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
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
            // usb5
            // 
            this.usb5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb5.Location = new System.Drawing.Point(6, 11);
            this.usb5.Name = "usb5";
            this.usb5.Size = new System.Drawing.Size(96, 30);
            this.usb5.TabIndex = 3;
            this.usb5.Text = "USB5";
            this.usb5.UseVisualStyleBackColor = true;
            this.usb5.Click += new System.EventHandler(this.button4_Click);
            // 
            // cable9
            // 
            this.cable9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cable9.Location = new System.Drawing.Point(6, 11);
            this.cable9.Name = "cable9";
            this.cable9.Size = new System.Drawing.Size(96, 31);
            this.cable9.TabIndex = 2;
            this.cable9.Text = "Cable9";
            this.cable9.UseVisualStyleBackColor = true;
            this.cable9.Click += new System.EventHandler(this.button3_Click);
            // 
            // camera13
            // 
            this.camera13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera13.Location = new System.Drawing.Point(6, 8);
            this.camera13.Name = "camera13";
            this.camera13.Size = new System.Drawing.Size(101, 30);
            this.camera13.TabIndex = 1;
            this.camera13.Text = "Camera13";
            this.camera13.UseVisualStyleBackColor = true;
            this.camera13.Click += new System.EventHandler(this.button2_Click);
            // 
            // charger1
            // 
            this.charger1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charger1.Location = new System.Drawing.Point(3, 11);
            this.charger1.Name = "charger1";
            this.charger1.Size = new System.Drawing.Size(96, 30);
            this.charger1.TabIndex = 0;
            this.charger1.Text = "Charger1";
            this.charger1.UseVisualStyleBackColor = true;
            this.charger1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 51);
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
            this.label3.Size = new System.Drawing.Size(279, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "VestroVestival Equipment Rent";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbuserid
            // 
            this.lbuserid.AutoSize = true;
            this.lbuserid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserid.Location = new System.Drawing.Point(348, 35);
            this.lbuserid.Name = "lbuserid";
            this.lbuserid.Size = new System.Drawing.Size(29, 19);
            this.lbuserid.TabIndex = 38;
            this.lbuserid.Text = ".....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "UserID:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(9, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 31);
            this.button6.TabIndex = 40;
            this.button6.Text = "EXIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.chargerTab);
            this.panel1.Location = new System.Drawing.Point(339, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 121);
            this.panel1.TabIndex = 41;
            // 
            // chargerTab
            // 
            this.chargerTab.Controls.Add(this.tabPage1);
            this.chargerTab.Controls.Add(this.tabPage2);
            this.chargerTab.Controls.Add(this.tabPage3);
            this.chargerTab.Controls.Add(this.tabPage4);
            this.chargerTab.Location = new System.Drawing.Point(0, 3);
            this.chargerTab.Name = "chargerTab";
            this.chargerTab.SelectedIndex = 0;
            this.chargerTab.Size = new System.Drawing.Size(254, 118);
            this.chargerTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Thistle;
            this.tabPage1.Controls.Add(this.Charger4);
            this.tabPage1.Controls.Add(this.Charger3);
            this.tabPage1.Controls.Add(this.Charger2);
            this.tabPage1.Controls.Add(this.charger1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chargers";
            // 
            // Charger4
            // 
            this.Charger4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charger4.Location = new System.Drawing.Point(129, 47);
            this.Charger4.Name = "Charger4";
            this.Charger4.Size = new System.Drawing.Size(96, 30);
            this.Charger4.TabIndex = 3;
            this.Charger4.Text = "Charger4";
            this.Charger4.UseVisualStyleBackColor = true;
            this.Charger4.Click += new System.EventHandler(this.Charger4_Click);
            // 
            // Charger3
            // 
            this.Charger3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charger3.Location = new System.Drawing.Point(3, 47);
            this.Charger3.Name = "Charger3";
            this.Charger3.Size = new System.Drawing.Size(96, 30);
            this.Charger3.TabIndex = 2;
            this.Charger3.Text = "Charger3";
            this.Charger3.UseVisualStyleBackColor = true;
            this.Charger3.Click += new System.EventHandler(this.Charger3_Click);
            // 
            // Charger2
            // 
            this.Charger2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charger2.Location = new System.Drawing.Point(129, 11);
            this.Charger2.Name = "Charger2";
            this.Charger2.Size = new System.Drawing.Size(96, 30);
            this.Charger2.TabIndex = 1;
            this.Charger2.Text = "Charger2";
            this.Charger2.UseVisualStyleBackColor = true;
            this.Charger2.Click += new System.EventHandler(this.Charger2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Thistle;
            this.tabPage2.Controls.Add(this.USB8);
            this.tabPage2.Controls.Add(this.USB7);
            this.tabPage2.Controls.Add(this.usb6);
            this.tabPage2.Controls.Add(this.usb5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USB";
            // 
            // USB8
            // 
            this.USB8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USB8.Location = new System.Drawing.Point(128, 47);
            this.USB8.Name = "USB8";
            this.USB8.Size = new System.Drawing.Size(96, 30);
            this.USB8.TabIndex = 6;
            this.USB8.Text = "USB8";
            this.USB8.UseVisualStyleBackColor = true;
            this.USB8.Click += new System.EventHandler(this.USB8_Click);
            // 
            // USB7
            // 
            this.USB7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USB7.Location = new System.Drawing.Point(6, 47);
            this.USB7.Name = "USB7";
            this.USB7.Size = new System.Drawing.Size(96, 30);
            this.USB7.TabIndex = 5;
            this.USB7.Text = "USB7";
            this.USB7.UseVisualStyleBackColor = true;
            this.USB7.Click += new System.EventHandler(this.USB7_Click);
            // 
            // usb6
            // 
            this.usb6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb6.Location = new System.Drawing.Point(128, 11);
            this.usb6.Name = "usb6";
            this.usb6.Size = new System.Drawing.Size(96, 30);
            this.usb6.TabIndex = 4;
            this.usb6.Text = "USB6";
            this.usb6.UseVisualStyleBackColor = true;
            this.usb6.Click += new System.EventHandler(this.usb6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Thistle;
            this.tabPage3.Controls.Add(this.CABLE12);
            this.tabPage3.Controls.Add(this.CABLE10);
            this.tabPage3.Controls.Add(this.CABLE11);
            this.tabPage3.Controls.Add(this.cable9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(246, 92);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cables";
            // 
            // CABLE12
            // 
            this.CABLE12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CABLE12.Location = new System.Drawing.Point(134, 56);
            this.CABLE12.Name = "CABLE12";
            this.CABLE12.Size = new System.Drawing.Size(96, 30);
            this.CABLE12.TabIndex = 5;
            this.CABLE12.Text = "CABLE12";
            this.CABLE12.UseVisualStyleBackColor = true;
            this.CABLE12.Click += new System.EventHandler(this.CABLE12_Click);
            // 
            // CABLE10
            // 
            this.CABLE10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CABLE10.Location = new System.Drawing.Point(134, 11);
            this.CABLE10.Name = "CABLE10";
            this.CABLE10.Size = new System.Drawing.Size(96, 31);
            this.CABLE10.TabIndex = 4;
            this.CABLE10.Text = "CABLE10";
            this.CABLE10.UseVisualStyleBackColor = true;
            this.CABLE10.Click += new System.EventHandler(this.CABLE10_Click);
            // 
            // CABLE11
            // 
            this.CABLE11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CABLE11.Location = new System.Drawing.Point(6, 56);
            this.CABLE11.Name = "CABLE11";
            this.CABLE11.Size = new System.Drawing.Size(96, 30);
            this.CABLE11.TabIndex = 3;
            this.CABLE11.Text = "CABLE11";
            this.CABLE11.UseVisualStyleBackColor = true;
            this.CABLE11.Click += new System.EventHandler(this.CABLE11_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Thistle;
            this.tabPage4.Controls.Add(this.CAMERA16);
            this.tabPage4.Controls.Add(this.CAMERA15);
            this.tabPage4.Controls.Add(this.CAMERA14);
            this.tabPage4.Controls.Add(this.camera13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(246, 92);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cameras";
            // 
            // CAMERA16
            // 
            this.CAMERA16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAMERA16.Location = new System.Drawing.Point(144, 56);
            this.CAMERA16.Name = "CAMERA16";
            this.CAMERA16.Size = new System.Drawing.Size(96, 30);
            this.CAMERA16.TabIndex = 4;
            this.CAMERA16.Text = "CAMERA16";
            this.CAMERA16.UseVisualStyleBackColor = true;
            this.CAMERA16.Click += new System.EventHandler(this.CAMERA16_Click);
            // 
            // CAMERA15
            // 
            this.CAMERA15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAMERA15.Location = new System.Drawing.Point(6, 56);
            this.CAMERA15.Name = "CAMERA15";
            this.CAMERA15.Size = new System.Drawing.Size(101, 30);
            this.CAMERA15.TabIndex = 3;
            this.CAMERA15.Text = "CAMERA15";
            this.CAMERA15.UseVisualStyleBackColor = true;
            this.CAMERA15.Click += new System.EventHandler(this.CAMERA15_Click);
            // 
            // CAMERA14
            // 
            this.CAMERA14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAMERA14.Location = new System.Drawing.Point(144, 8);
            this.CAMERA14.Name = "CAMERA14";
            this.CAMERA14.Size = new System.Drawing.Size(96, 30);
            this.CAMERA14.TabIndex = 2;
            this.CAMERA14.Text = "CAMERA14";
            this.CAMERA14.UseVisualStyleBackColor = true;
            this.CAMERA14.Click += new System.EventHandler(this.CAMERA14_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Products";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(235, 287);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(56, 30);
            this.print.TabIndex = 44;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // EquipmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 329);
            this.ControlBox = false;
            this.Controls.Add(this.print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbuserid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbEventID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonClearItem);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dataGridVisitor);
            this.Name = "EquipmentShop";
            this.Text = "EquipmentShop";
            this.Load += new System.EventHandler(this.EquipmentShop_Load);
            this.DoubleClick += new System.EventHandler(this.EquipmentShop_DoubleClick);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.chargerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentPrice;
        private System.Windows.Forms.Button usb5;
        private System.Windows.Forms.Button cable9;
        private System.Windows.Forms.Button camera13;
        private System.Windows.Forms.Button charger1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbuserid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl chargerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Charger4;
        private System.Windows.Forms.Button Charger3;
        private System.Windows.Forms.Button Charger2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button USB8;
        private System.Windows.Forms.Button USB7;
        private System.Windows.Forms.Button usb6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CABLE12;
        private System.Windows.Forms.Button CABLE10;
        private System.Windows.Forms.Button CABLE11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button CAMERA16;
        private System.Windows.Forms.Button CAMERA15;
        private System.Windows.Forms.Button CAMERA14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button print;
    }
}
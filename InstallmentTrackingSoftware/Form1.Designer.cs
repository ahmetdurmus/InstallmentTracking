namespace InstallmentTrackingSoftware
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpUrun = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTradeMark = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbInstallment = new System.Windows.Forms.ComboBox();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.rtxtCutomerAddress = new System.Windows.Forms.RichTextBox();
            this.txtCustomerNameSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpInstallmentTable = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InstallmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbNewModel = new System.Windows.Forms.ComboBox();
            this.cmbNewTradeMark = new System.Windows.Forms.ComboBox();
            this.cmbNewProducts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpUrun.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpInstallmentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 416);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpUrun);
            this.tabPage1.Controls.Add(this.grpMusteri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpUrun
            // 
            this.grpUrun.Controls.Add(this.label15);
            this.grpUrun.Controls.Add(this.label14);
            this.grpUrun.Controls.Add(this.label13);
            this.grpUrun.Controls.Add(this.button7);
            this.grpUrun.Controls.Add(this.cmbSelectCustomer);
            this.grpUrun.Controls.Add(this.label12);
            this.grpUrun.Controls.Add(this.cmbModel);
            this.grpUrun.Controls.Add(this.label11);
            this.grpUrun.Controls.Add(this.button1);
            this.grpUrun.Controls.Add(this.cmbTradeMark);
            this.grpUrun.Controls.Add(this.label2);
            this.grpUrun.Controls.Add(this.label1);
            this.grpUrun.Controls.Add(this.cmbProducts);
            this.grpUrun.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpUrun.Location = new System.Drawing.Point(3, 3);
            this.grpUrun.Name = "grpUrun";
            this.grpUrun.Size = new System.Drawing.Size(343, 384);
            this.grpUrun.TabIndex = 6;
            this.grpUrun.TabStop = false;
            this.grpUrun.Text = "Ürün Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Toplam : ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(210, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Yeni*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Location = new System.Drawing.Point(80, 189);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(113, 21);
            this.cmbSelectCustomer.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Müşteri";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(80, 142);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(184, 21);
            this.cmbModel.TabIndex = 11;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Devam Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTradeMark
            // 
            this.cmbTradeMark.FormattingEnabled = true;
            this.cmbTradeMark.Location = new System.Drawing.Point(80, 95);
            this.cmbTradeMark.Name = "cmbTradeMark";
            this.cmbTradeMark.Size = new System.Drawing.Size(184, 21);
            this.cmbTradeMark.TabIndex = 8;
            this.cmbTradeMark.SelectedIndexChanged += new System.EventHandler(this.cmbTradeMark_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürünler";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(80, 48);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(184, 21);
            this.cmbProducts.TabIndex = 5;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.button2);
            this.grpMusteri.Controls.Add(this.cmbInstallment);
            this.grpMusteri.Controls.Add(this.txtAdvancePayment);
            this.grpMusteri.Controls.Add(this.rtxtCutomerAddress);
            this.grpMusteri.Controls.Add(this.txtCustomerNameSurname);
            this.grpMusteri.Controls.Add(this.label6);
            this.grpMusteri.Controls.Add(this.label5);
            this.grpMusteri.Controls.Add(this.label4);
            this.grpMusteri.Controls.Add(this.label3);
            this.grpMusteri.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMusteri.Location = new System.Drawing.Point(352, 3);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(381, 384);
            this.grpMusteri.TabIndex = 5;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Bilgileri";
            this.grpMusteri.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbInstallment
            // 
            this.cmbInstallment.FormattingEnabled = true;
            this.cmbInstallment.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "18",
            "24"});
            this.cmbInstallment.Location = new System.Drawing.Point(134, 222);
            this.cmbInstallment.Name = "cmbInstallment";
            this.cmbInstallment.Size = new System.Drawing.Size(195, 21);
            this.cmbInstallment.TabIndex = 7;
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Location = new System.Drawing.Point(134, 175);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(195, 20);
            this.txtAdvancePayment.TabIndex = 6;
            // 
            // rtxtCutomerAddress
            // 
            this.rtxtCutomerAddress.Location = new System.Drawing.Point(134, 81);
            this.rtxtCutomerAddress.Name = "rtxtCutomerAddress";
            this.rtxtCutomerAddress.ReadOnly = true;
            this.rtxtCutomerAddress.Size = new System.Drawing.Size(195, 74);
            this.rtxtCutomerAddress.TabIndex = 5;
            this.rtxtCutomerAddress.Text = "";
            // 
            // txtCustomerNameSurname
            // 
            this.txtCustomerNameSurname.Location = new System.Drawing.Point(134, 44);
            this.txtCustomerNameSurname.Name = "txtCustomerNameSurname";
            this.txtCustomerNameSurname.ReadOnly = true;
            this.txtCustomerNameSurname.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerNameSurname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Taksit Seçenekleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Peşinat Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı Soyadı";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpInstallmentTable);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.cmbCustomer);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpInstallmentTable
            // 
            this.grpInstallmentTable.Controls.Add(this.dataGridView2);
            this.grpInstallmentTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpInstallmentTable.Location = new System.Drawing.Point(446, 3);
            this.grpInstallmentTable.Name = "grpInstallmentTable";
            this.grpInstallmentTable.Size = new System.Drawing.Size(287, 384);
            this.grpInstallmentTable.TabIndex = 3;
            this.grpInstallmentTable.TabStop = false;
            this.grpInstallmentTable.Text = "Taksit Tablosu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button,
            this.InstallmentId,
            this.Date,
            this.Amount,
            this.State});
            this.dataGridView2.Location = new System.Drawing.Point(7, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(274, 340);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button
            // 
            this.button.HeaderText = "Ödeme";
            this.button.Name = "button";
            this.button.Text = "Güncelle";
            this.button.UseColumnTextForButtonValue = true;
            // 
            // InstallmentId
            // 
            this.InstallmentId.DataPropertyName = "Id";
            this.InstallmentId.HeaderText = "Taksit Id";
            this.InstallmentId.Name = "InstallmentId";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Tarih";
            this.Date.Name = "Date";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Aylık Ücret";
            this.Amount.Name = "Amount";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Durum";
            this.State.Name = "State";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.TradeMark,
            this.Model,
            this.SumAmount,
            this.AdvancePayment,
            this.RemainingAmount,
            this.Installment});
            this.dataGridView1.Location = new System.Drawing.Point(6, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 270);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Müşteri Id";
            this.Id.Name = "Id";
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Ürün";
            this.Product.Name = "Product";
            // 
            // TradeMark
            // 
            this.TradeMark.DataPropertyName = "TradeMark";
            this.TradeMark.HeaderText = "Marka";
            this.TradeMark.Name = "TradeMark";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // SumAmount
            // 
            this.SumAmount.DataPropertyName = "SumAmount";
            this.SumAmount.HeaderText = "Toplam Tutar";
            this.SumAmount.Name = "SumAmount";
            // 
            // AdvancePayment
            // 
            this.AdvancePayment.DataPropertyName = "AdvancePayment";
            this.AdvancePayment.HeaderText = "Peşinat";
            this.AdvancePayment.Name = "AdvancePayment";
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.DataPropertyName = "RemainingAmount";
            this.RemainingAmount.HeaderText = "Kalan";
            this.RemainingAmount.Name = "RemainingAmount";
            // 
            // Installment
            // 
            this.Installment.DataPropertyName = "Installment";
            this.Installment.HeaderText = "Taksit";
            this.Installment.Name = "Installment";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(142, 41);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(205, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri Seçiniz";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.cmbNewModel);
            this.tabPage3.Controls.Add(this.cmbNewTradeMark);
            this.tabPage3.Controls.Add(this.cmbNewProducts);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(736, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yeni Ekle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(457, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Yeni Model Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Yeni Marka Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(457, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Yeni Ürün Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbNewModel
            // 
            this.cmbNewModel.FormattingEnabled = true;
            this.cmbNewModel.Location = new System.Drawing.Point(270, 195);
            this.cmbNewModel.Name = "cmbNewModel";
            this.cmbNewModel.Size = new System.Drawing.Size(141, 21);
            this.cmbNewModel.TabIndex = 5;
            this.cmbNewModel.Visible = false;
            // 
            // cmbNewTradeMark
            // 
            this.cmbNewTradeMark.FormattingEnabled = true;
            this.cmbNewTradeMark.Location = new System.Drawing.Point(270, 136);
            this.cmbNewTradeMark.Name = "cmbNewTradeMark";
            this.cmbNewTradeMark.Size = new System.Drawing.Size(141, 21);
            this.cmbNewTradeMark.TabIndex = 4;
            this.cmbNewTradeMark.Visible = false;
            this.cmbNewTradeMark.SelectedIndexChanged += new System.EventHandler(this.cmbNewTradeMark_SelectedIndexChanged);
            // 
            // cmbNewProducts
            // 
            this.cmbNewProducts.FormattingEnabled = true;
            this.cmbNewProducts.Location = new System.Drawing.Point(270, 77);
            this.cmbNewProducts.Name = "cmbNewProducts";
            this.cmbNewProducts.Size = new System.Drawing.Size(141, 21);
            this.cmbNewProducts.TabIndex = 3;
            this.cmbNewProducts.SelectedIndexChanged += new System.EventHandler(this.cmbNewProducts_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Model";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Marka";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürünler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 416);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TAKSİT TAKİP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpUrun.ResumeLayout(false);
            this.grpUrun.PerformLayout();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpInstallmentTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpUrun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTradeMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbInstallment;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.RichTextBox rtxtCutomerAddress;
        private System.Windows.Forms.TextBox txtCustomerNameSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpInstallmentTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbNewModel;
        private System.Windows.Forms.ComboBox cmbNewTradeMark;
        private System.Windows.Forms.ComboBox cmbNewProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmbSelectCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvancePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installment;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}


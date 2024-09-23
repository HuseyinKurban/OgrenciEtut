namespace OgrenciEtut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnetutolustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.cmbogretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnetutdetay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtetutogrenci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtetutid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtogrenciad = new System.Windows.Forms.TextBox();
            this.txtogrencisoyad = new System.Windows.Forms.TextBox();
            this.txtogrencisınıf = new System.Windows.Forms.TextBox();
            this.txtogrencimail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.mskogrencitelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtders = new System.Windows.Forms.TextBox();
            this.btndersekle = new System.Windows.Forms.Button();
            this.btnfotograf = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtogretmenad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtogretmensoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnogretmenekle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbogretmenders = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders :";
            // 
            // btnetutolustur
            // 
            this.btnetutolustur.BackColor = System.Drawing.Color.Cyan;
            this.btnetutolustur.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnetutolustur.Location = new System.Drawing.Point(330, 214);
            this.btnetutolustur.Name = "btnetutolustur";
            this.btnetutolustur.Size = new System.Drawing.Size(142, 81);
            this.btnetutolustur.TabIndex = 2;
            this.btnetutolustur.Text = "Etüt Oluştur";
            this.btnetutolustur.UseVisualStyleBackColor = false;
            this.btnetutolustur.Click += new System.EventHandler(this.btnetutolustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msksaat);
            this.groupBox1.Controls.Add(this.btnetutolustur);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbogretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbders
            // 
            this.cmbders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(194, 45);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(278, 39);
            this.cmbders.TabIndex = 2;
            this.cmbders.SelectedIndexChanged += new System.EventHandler(this.cmbders_SelectedIndexChanged);
            // 
            // cmbogretmen
            // 
            this.cmbogretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbogretmen.FormattingEnabled = true;
            this.cmbogretmen.Location = new System.Drawing.Point(194, 107);
            this.cmbogretmen.Name = "cmbogretmen";
            this.cmbogretmen.Size = new System.Drawing.Size(278, 39);
            this.cmbogretmen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğretmen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat :";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(194, 171);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(160, 38);
            this.msktarih.TabIndex = 8;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(194, 244);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(98, 38);
            this.msksaat.TabIndex = 9;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtetutid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtetutogrenci);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnetutdetay);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(520, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnetutdetay
            // 
            this.btnetutdetay.BackColor = System.Drawing.Color.Cyan;
            this.btnetutdetay.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnetutdetay.ForeColor = System.Drawing.Color.Black;
            this.btnetutdetay.Location = new System.Drawing.Point(227, 144);
            this.btnetutdetay.Name = "btnetutdetay";
            this.btnetutdetay.Size = new System.Drawing.Size(144, 40);
            this.btnetutdetay.TabIndex = 2;
            this.btnetutdetay.Text = "Etüt Ver";
            this.btnetutdetay.UseVisualStyleBackColor = false;
            this.btnetutdetay.Click += new System.EventHandler(this.btnetutdetay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Öğrenci :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1294, 309);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtetutogrenci
            // 
            this.txtetutogrenci.Location = new System.Drawing.Point(171, 100);
            this.txtetutogrenci.Name = "txtetutogrenci";
            this.txtetutogrenci.Size = new System.Drawing.Size(200, 38);
            this.txtetutogrenci.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etüt İd:";
            // 
            // txtetutid
            // 
            this.txtetutid.Enabled = false;
            this.txtetutid.Location = new System.Drawing.Point(171, 37);
            this.txtetutid.Name = "txtetutid";
            this.txtetutid.Size = new System.Drawing.Size(200, 38);
            this.txtetutid.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnfotograf);
            this.groupBox4.Controls.Add(this.mskogrencitelefon);
            this.groupBox4.Controls.Add(this.btnogrenciekle);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.txtogrencimail);
            this.groupBox4.Controls.Add(this.txtogrencisınıf);
            this.groupBox4.Controls.Add(this.txtogrencisoyad);
            this.groupBox4.Controls.Add(this.txtogrenciad);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1312, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 632);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Soyad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sınıf :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(45, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mail :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 31);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefon :";
            // 
            // txtogrenciad
            // 
            this.txtogrenciad.Location = new System.Drawing.Point(148, 276);
            this.txtogrenciad.Name = "txtogrenciad";
            this.txtogrenciad.Size = new System.Drawing.Size(182, 38);
            this.txtogrenciad.TabIndex = 15;
            // 
            // txtogrencisoyad
            // 
            this.txtogrencisoyad.Location = new System.Drawing.Point(148, 323);
            this.txtogrencisoyad.Name = "txtogrencisoyad";
            this.txtogrencisoyad.Size = new System.Drawing.Size(182, 38);
            this.txtogrencisoyad.TabIndex = 16;
            // 
            // txtogrencisınıf
            // 
            this.txtogrencisınıf.Location = new System.Drawing.Point(148, 370);
            this.txtogrencisınıf.Name = "txtogrencisınıf";
            this.txtogrencisınıf.Size = new System.Drawing.Size(182, 38);
            this.txtogrencisınıf.TabIndex = 17;
            // 
            // txtogrencimail
            // 
            this.txtogrencimail.Location = new System.Drawing.Point(148, 472);
            this.txtogrencimail.Name = "txtogrencimail";
            this.txtogrencimail.Size = new System.Drawing.Size(182, 38);
            this.txtogrencimail.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.BackColor = System.Drawing.Color.Cyan;
            this.btnogrenciekle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciekle.ForeColor = System.Drawing.Color.Black;
            this.btnogrenciekle.Location = new System.Drawing.Point(148, 544);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(144, 70);
            this.btnogrenciekle.TabIndex = 21;
            this.btnogrenciekle.Text = "Öğrenci Ekle";
            this.btnogrenciekle.UseVisualStyleBackColor = false;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // mskogrencitelefon
            // 
            this.mskogrencitelefon.Location = new System.Drawing.Point(148, 422);
            this.mskogrencitelefon.Mask = "0000000000";
            this.mskogrencitelefon.Name = "mskogrencitelefon";
            this.mskogrencitelefon.Size = new System.Drawing.Size(182, 38);
            this.mskogrencitelefon.TabIndex = 22;
            this.mskogrencitelefon.ValidatingType = typeof(int);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btndersekle);
            this.groupBox5.Controls.Add(this.txtders);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(520, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 99);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ders Ekle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ders :";
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(109, 38);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(200, 38);
            this.txtders.TabIndex = 13;
            // 
            // btndersekle
            // 
            this.btndersekle.BackColor = System.Drawing.Color.Cyan;
            this.btndersekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndersekle.BackgroundImage")));
            this.btndersekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndersekle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndersekle.Location = new System.Drawing.Point(315, 37);
            this.btndersekle.Name = "btndersekle";
            this.btndersekle.Size = new System.Drawing.Size(56, 40);
            this.btndersekle.TabIndex = 14;
            this.btndersekle.UseVisualStyleBackColor = false;
            this.btndersekle.Click += new System.EventHandler(this.btndersekle_Click);
            // 
            // btnfotograf
            // 
            this.btnfotograf.BackColor = System.Drawing.Color.Black;
            this.btnfotograf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfotograf.BackgroundImage")));
            this.btnfotograf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfotograf.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfotograf.Location = new System.Drawing.Point(291, 230);
            this.btnfotograf.Name = "btnfotograf";
            this.btnfotograf.Size = new System.Drawing.Size(56, 40);
            this.btnfotograf.TabIndex = 23;
            this.btnfotograf.UseVisualStyleBackColor = false;
            this.btnfotograf.Click += new System.EventHandler(this.btnresim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbogretmenders);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtogretmenad);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtogretmensoyad);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.btnogretmenekle);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(916, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 307);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Öğretmen Ekle";
            // 
            // txtogretmenad
            // 
            this.txtogretmenad.Location = new System.Drawing.Point(132, 37);
            this.txtogretmenad.Name = "txtogretmenad";
            this.txtogretmenad.Size = new System.Drawing.Size(234, 38);
            this.txtogretmenad.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 31);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ad :";
            // 
            // txtogretmensoyad
            // 
            this.txtogretmensoyad.Location = new System.Drawing.Point(132, 103);
            this.txtogretmensoyad.Name = "txtogretmensoyad";
            this.txtogretmensoyad.Size = new System.Drawing.Size(234, 38);
            this.txtogretmensoyad.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 31);
            this.label14.TabIndex = 4;
            this.label14.Text = "Soyad :";
            // 
            // btnogretmenekle
            // 
            this.btnogretmenekle.BackColor = System.Drawing.Color.Cyan;
            this.btnogretmenekle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogretmenekle.ForeColor = System.Drawing.Color.Black;
            this.btnogretmenekle.Location = new System.Drawing.Point(222, 214);
            this.btnogretmenekle.Name = "btnogretmenekle";
            this.btnogretmenekle.Size = new System.Drawing.Size(144, 81);
            this.btnogretmenekle.TabIndex = 2;
            this.btnogretmenekle.Text = "Öğretmen Ekle";
            this.btnogretmenekle.UseVisualStyleBackColor = false;
            this.btnogretmenekle.Click += new System.EventHandler(this.btnogretmenekle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(29, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 31);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ders :";
            // 
            // cmbogretmenders
            // 
            this.cmbogretmenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbogretmenders.FormattingEnabled = true;
            this.cmbogretmenders.Location = new System.Drawing.Point(132, 163);
            this.cmbogretmenders.Name = "cmbogretmenders";
            this.cmbogretmenders.Size = new System.Drawing.Size(234, 39);
            this.cmbogretmenders.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1713, 656);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnetutolustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnetutdetay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtetutid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtetutogrenci;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtogrencimail;
        private System.Windows.Forms.TextBox txtogrencisınıf;
        private System.Windows.Forms.TextBox txtogrencisoyad;
        private System.Windows.Forms.TextBox txtogrenciad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.MaskedTextBox mskogrencitelefon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btndersekle;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnfotograf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtogretmenad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtogretmensoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnogretmenekle;
        private System.Windows.Forms.ComboBox cmbogretmenders;
    }
}


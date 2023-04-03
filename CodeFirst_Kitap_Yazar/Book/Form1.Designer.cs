namespace Book_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEkle = new Button();
            txtKitapSayfaSayisi = new Label();
            label8 = new Label();
            txtKitapFiyatı = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            txtYazarSoyad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zamanın Kısa Tarihi", "Sürüngen İle Yılan ", "The Talisman", "Savaş Sanatı", "Evrenin Kısa Tarihi", "Zihin Uzayı" });
            comboBox1.Location = new Point(9, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 31);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Kitap Seçimi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(669, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 381);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(432, 31);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "Yazar Seçimi";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Stephen Hawking", "Leonard Mlodinow", "Margaret Atwood", "Graeme Gibson", "Stephen King", "Peter Straub", "Sun Tzu", "Lionel Giles" });
            comboBox2.Location = new Point(336, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(308, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(377, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 8;
            label3.Text = "Yazar Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 132);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 7;
            label4.Text = "Kitap Adı";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(25, 228);
            label5.Name = "label5";
            label5.Size = new Size(591, 40);
            label5.TabIndex = 9;
            label5.Text = "Kitap Yada Yazar Adı Araması yapmak için İsimlerini yazmanız yeterlidir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(673, 21);
            label6.Name = "label6";
            label6.Size = new Size(477, 20);
            label6.TabIndex = 10;
            label6.Text = "Güncelleme yapmak için stun üzerinde değişiklik yapmanı yeterlidir.";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(15, 384);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(305, 87);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtKitapSayfaSayisi
            // 
            txtKitapSayfaSayisi.AutoSize = true;
            txtKitapSayfaSayisi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtKitapSayfaSayisi.Location = new Point(405, 295);
            txtKitapSayfaSayisi.Name = "txtKitapSayfaSayisi";
            txtKitapSayfaSayisi.Size = new Size(162, 25);
            txtKitapSayfaSayisi.TabIndex = 15;
            txtKitapSayfaSayisi.Text = "Kitap Sayfa Sayisi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(100, 295);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 14;
            label8.Text = "Kitap Fiyatı";
            // 
            // txtKitapFiyatı
            // 
            txtKitapFiyatı.Location = new Point(15, 332);
            txtKitapFiyatı.Name = "txtKitapFiyatı";
            txtKitapFiyatı.Size = new Size(308, 27);
            txtKitapFiyatı.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(342, 332);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 27);
            textBox4.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(339, 384);
            button1.Name = "button1";
            button1.Size = new Size(305, 87);
            button1.TabIndex = 16;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(525, 132);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 18;
            label7.Text = "Yazar Soyadı";
            // 
            // txtYazarSoyad
            // 
            txtYazarSoyad.Location = new Point(502, 169);
            txtYazarSoyad.Name = "txtYazarSoyad";
            txtYazarSoyad.Size = new Size(165, 27);
            txtYazarSoyad.TabIndex = 17;
            txtYazarSoyad.TextChanged += txtYazarSoyad_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 483);
            Controls.Add(label7);
            Controls.Add(txtYazarSoyad);
            Controls.Add(button1);
            Controls.Add(txtKitapSayfaSayisi);
            Controls.Add(label8);
            Controls.Add(txtKitapFiyatı);
            Controls.Add(textBox4);
            Controls.Add(btnEkle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEkle;
        private Label txtKitapSayfaSayisi;
        private Label label8;
        private TextBox txtKitapFiyatı;
        private TextBox textBox4;
        private Button button1;
        private Label label7;
        private TextBox txtYazarSoyad;
    }
}
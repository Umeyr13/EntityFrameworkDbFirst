namespace EntityFrameworkDbFirst
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTedarikciler = new System.Windows.Forms.ComboBox();
            this.textBoxadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpdFiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpdStok = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUrunarama = new System.Windows.Forms.TextBox();
            this.radioButtonAzalan = new System.Windows.Forms.RadioButton();
            this.radioButtonArtan = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonrapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(13, 96);
            this.dataGridViewUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUrunler.MultiSelect = false;
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.RowHeadersWidth = 51;
            this.dataGridViewUrunler.RowTemplate.Height = 24;
            this.dataGridViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(967, 544);
            this.dataGridViewUrunler.TabIndex = 0;
            this.dataGridViewUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellClick);
            this.dataGridViewUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 28);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoriler";
            // 
            // comboBoxKategoriler
            // 
            this.comboBoxKategoriler.FormattingEnabled = true;
            this.comboBoxKategoriler.Location = new System.Drawing.Point(124, 6);
            this.comboBoxKategoriler.Name = "comboBoxKategoriler";
            this.comboBoxKategoriler.Size = new System.Drawing.Size(236, 33);
            this.comboBoxKategoriler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçiler";
            // 
            // comboBoxTedarikciler
            // 
            this.comboBoxTedarikciler.FormattingEnabled = true;
            this.comboBoxTedarikciler.Location = new System.Drawing.Point(478, 6);
            this.comboBoxTedarikciler.Name = "comboBoxTedarikciler";
            this.comboBoxTedarikciler.Size = new System.Drawing.Size(225, 33);
            this.comboBoxTedarikciler.TabIndex = 2;
            // 
            // textBoxadi
            // 
            this.textBoxadi.Location = new System.Drawing.Point(124, 53);
            this.textBoxadi.Name = "textBoxadi";
            this.textBoxadi.Size = new System.Drawing.Size(193, 30);
            this.textBoxadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Urun Adı";
            // 
            // numericUpdFiyat
            // 
            this.numericUpdFiyat.Location = new System.Drawing.Point(397, 53);
            this.numericUpdFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpdFiyat.Name = "numericUpdFiyat";
            this.numericUpdFiyat.Size = new System.Drawing.Size(120, 30);
            this.numericUpdFiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stok";
            // 
            // numericUpdStok
            // 
            this.numericUpdStok.Location = new System.Drawing.Point(583, 54);
            this.numericUpdStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpdStok.Name = "numericUpdStok";
            this.numericUpdStok.Size = new System.Drawing.Size(120, 30);
            this.numericUpdStok.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Urun adına göre arama:";
            // 
            // textBoxUrunarama
            // 
            this.textBoxUrunarama.Location = new System.Drawing.Point(242, 694);
            this.textBoxUrunarama.Name = "textBoxUrunarama";
            this.textBoxUrunarama.Size = new System.Drawing.Size(193, 30);
            this.textBoxUrunarama.TabIndex = 3;
            this.textBoxUrunarama.TextChanged += new System.EventHandler(this.textBoxUrunarama_TextChanged);
            // 
            // radioButtonAzalan
            // 
            this.radioButtonAzalan.AutoSize = true;
            this.radioButtonAzalan.Location = new System.Drawing.Point(651, 695);
            this.radioButtonAzalan.Name = "radioButtonAzalan";
            this.radioButtonAzalan.Size = new System.Drawing.Size(200, 29);
            this.radioButtonAzalan.TabIndex = 6;
            this.radioButtonAzalan.TabStop = true;
            this.radioButtonAzalan.Text = "Fiyata Göre Azalan";
            this.radioButtonAzalan.UseVisualStyleBackColor = true;
            this.radioButtonAzalan.CheckedChanged += new System.EventHandler(this.radioButtonAzalan_CheckedChanged);
            // 
            // radioButtonArtan
            // 
            this.radioButtonArtan.AutoSize = true;
            this.radioButtonArtan.Location = new System.Drawing.Point(459, 695);
            this.radioButtonArtan.Name = "radioButtonArtan";
            this.radioButtonArtan.Size = new System.Drawing.Size(186, 29);
            this.radioButtonArtan.TabIndex = 6;
            this.radioButtonArtan.TabStop = true;
            this.radioButtonArtan.Text = "Fiyata Göre Artan";
            this.radioButtonArtan.UseVisualStyleBackColor = true;
            this.radioButtonArtan.CheckedChanged += new System.EventHandler(this.radioButtonArtan_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 648);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Filtreleme";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 730);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Top - 10 ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(607, 730);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Last - 10";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonrapor
            // 
            this.buttonrapor.Location = new System.Drawing.Point(858, 12);
            this.buttonrapor.Name = "buttonrapor";
            this.buttonrapor.Size = new System.Drawing.Size(122, 33);
            this.buttonrapor.TabIndex = 5;
            this.buttonrapor.Text = "Raporlar";
            this.buttonrapor.UseVisualStyleBackColor = true;
            this.buttonrapor.Click += new System.EventHandler(this.buttonrapor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 818);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButtonArtan);
            this.Controls.Add(this.radioButtonAzalan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonrapor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpdStok);
            this.Controls.Add(this.numericUpdFiyat);
            this.Controls.Add(this.textBoxUrunarama);
            this.Controls.Add(this.textBoxadi);
            this.Controls.Add(this.comboBoxTedarikciler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxKategoriler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTedarikciler;
        private System.Windows.Forms.TextBox textBoxadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpdFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpdStok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUrunarama;
        private System.Windows.Forms.RadioButton radioButtonAzalan;
        private System.Windows.Forms.RadioButton radioButtonArtan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.Button buttonrapor;
    }
}


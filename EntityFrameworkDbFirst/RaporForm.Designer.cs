namespace EntityFrameworkDbFirst
{
    partial class RaporForm
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
            this.dataGridViewrapor = new System.Windows.Forms.DataGridView();
            this.buttonurunsatis = new System.Windows.Forms.Button();
            this.button_ted_kad_rapor = new System.Windows.Forms.Button();
            this.button_msatis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewrapor
            // 
            this.dataGridViewrapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrapor.Location = new System.Drawing.Point(20, 61);
            this.dataGridViewrapor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridViewrapor.Name = "dataGridViewrapor";
            this.dataGridViewrapor.RowHeadersWidth = 51;
            this.dataGridViewrapor.RowTemplate.Height = 24;
            this.dataGridViewrapor.Size = new System.Drawing.Size(1122, 651);
            this.dataGridViewrapor.TabIndex = 0;
            // 
            // buttonurunsatis
            // 
            this.buttonurunsatis.Location = new System.Drawing.Point(14, 14);
            this.buttonurunsatis.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonurunsatis.Name = "buttonurunsatis";
            this.buttonurunsatis.Size = new System.Drawing.Size(230, 37);
            this.buttonurunsatis.TabIndex = 1;
            this.buttonurunsatis.Text = "Urun Satış Raporu";
            this.buttonurunsatis.UseVisualStyleBackColor = true;
            this.buttonurunsatis.Click += new System.EventHandler(this.buttonurunsatis_Click);
            // 
            // button_ted_kad_rapor
            // 
            this.button_ted_kad_rapor.Location = new System.Drawing.Point(254, 14);
            this.button_ted_kad_rapor.Margin = new System.Windows.Forms.Padding(5);
            this.button_ted_kad_rapor.Name = "button_ted_kad_rapor";
            this.button_ted_kad_rapor.Size = new System.Drawing.Size(281, 37);
            this.button_ted_kad_rapor.TabIndex = 1;
            this.button_ted_kad_rapor.Text = "Tedarikçi Kategori Raporu";
            this.button_ted_kad_rapor.UseVisualStyleBackColor = true;
            this.button_ted_kad_rapor.Click += new System.EventHandler(this.button_ted_kad_rapor_Click);
            // 
            // button_msatis
            // 
            this.button_msatis.Location = new System.Drawing.Point(545, 14);
            this.button_msatis.Margin = new System.Windows.Forms.Padding(5);
            this.button_msatis.Name = "button_msatis";
            this.button_msatis.Size = new System.Drawing.Size(281, 37);
            this.button_msatis.TabIndex = 1;
            this.button_msatis.Text = "Müşteri Satış Raporu";
            this.button_msatis.UseVisualStyleBackColor = true;
            this.button_msatis.Click += new System.EventHandler(this.button_msatis_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 742);
            this.Controls.Add(this.button_msatis);
            this.Controls.Add(this.button_ted_kad_rapor);
            this.Controls.Add(this.buttonurunsatis);
            this.Controls.Add(this.dataGridViewrapor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewrapor;
        private System.Windows.Forms.Button buttonurunsatis;
        private System.Windows.Forms.Button button_ted_kad_rapor;
        private System.Windows.Forms.Button button_msatis;
    }
}
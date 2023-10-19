namespace Kafe
{
    partial class UrunlerForm
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
            label1 = new Label();
            label2 = new Label();
            txtUrunAd = new TextBox();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(239, 9);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyatı(₺);";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 40);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(217, 27);
            txtUrunAd.TabIndex = 3;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(239, 41);
            nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(159, 27);
            nudBirimFiyat.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(426, 41);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 74);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 29;
            dgvUrunler.Size = new Size(776, 364);
            dgvUrunler.TabIndex = 9;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(txtUrunAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Urunler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUrunAd;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}
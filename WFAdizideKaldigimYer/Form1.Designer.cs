
namespace WFAdizideKaldigimYer
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
            this.Ad = new System.Windows.Forms.Label();
            this.txtDiziAd = new System.Windows.Forms.TextBox();
            this.cboBittiMi = new System.Windows.Forms.CheckBox();
            this.dgvDiziler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSezonNo = new System.Windows.Forms.NumericUpDown();
            this.numBolumNo = new System.Windows.Forms.NumericUpDown();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiziler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSezonNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBolumNo)).BeginInit();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(11, 19);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(61, 18);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Dizi Ad";
            // 
            // txtDiziAd
            // 
            this.txtDiziAd.Location = new System.Drawing.Point(114, 12);
            this.txtDiziAd.Name = "txtDiziAd";
            this.txtDiziAd.Size = new System.Drawing.Size(158, 24);
            this.txtDiziAd.TabIndex = 1;
            // 
            // cboBittiMi
            // 
            this.cboBittiMi.AutoSize = true;
            this.cboBittiMi.Location = new System.Drawing.Point(290, 14);
            this.cboBittiMi.Name = "cboBittiMi";
            this.cboBittiMi.Size = new System.Drawing.Size(88, 22);
            this.cboBittiMi.TabIndex = 2;
            this.cboBittiMi.Text = "Bitti Mi?";
            this.cboBittiMi.UseVisualStyleBackColor = true;
            // 
            // dgvDiziler
            // 
            this.dgvDiziler.AllowUserToAddRows = false;
            this.dgvDiziler.AllowUserToDeleteRows = false;
            this.dgvDiziler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiziler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiziler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiziler.Location = new System.Drawing.Point(12, 123);
            this.dgvDiziler.MultiSelect = false;
            this.dgvDiziler.Name = "dgvDiziler";
            this.dgvDiziler.ReadOnly = true;
            this.dgvDiziler.RowHeadersVisible = false;
            this.dgvDiziler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiziler.Size = new System.Drawing.Size(570, 249);
            this.dgvDiziler.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(290, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sezon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm No";
            // 
            // numSezonNo
            // 
            this.numSezonNo.Location = new System.Drawing.Point(114, 53);
            this.numSezonNo.Name = "numSezonNo";
            this.numSezonNo.Size = new System.Drawing.Size(158, 24);
            this.numSezonNo.TabIndex = 7;
            // 
            // numBolumNo
            // 
            this.numBolumNo.Location = new System.Drawing.Point(114, 93);
            this.numBolumNo.Name = "numBolumNo";
            this.numBolumNo.Size = new System.Drawing.Size(158, 24);
            this.numBolumNo.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.Location = new System.Drawing.Point(14, 378);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 25);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Yellow;
            this.btnDuzenle.Location = new System.Drawing.Point(114, 378);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(107, 25);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(290, 87);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(81, 29);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(426, 89);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(156, 24);
            this.txtAra.TabIndex = 12;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.numBolumNo);
            this.Controls.Add(this.numSezonNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvDiziler);
            this.Controls.Add(this.cboBittiMi);
            this.Controls.Add(this.txtDiziAd);
            this.Controls.Add(this.Ad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dizide Kaldığım Yer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiziler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSezonNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBolumNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txtDiziAd;
        private System.Windows.Forms.CheckBox cboBittiMi;
        private System.Windows.Forms.DataGridView dgvDiziler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSezonNo;
        private System.Windows.Forms.NumericUpDown numBolumNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label3;
    }
}


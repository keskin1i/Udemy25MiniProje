namespace BankaTest
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskHesap = new System.Windows.Forms.MaskedTextBox();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.btnKydet = new System.Windows.Forms.Button();
            this.btnHesapGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC KİMLİK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "HESAP NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ŞİFRE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "TELEFON :";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(168, 58);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(152, 30);
            this.txAd.TabIndex = 6;
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(168, 100);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(152, 30);
            this.txSoyad.TabIndex = 7;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(168, 145);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(152, 30);
            this.mskTc.TabIndex = 8;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(168, 189);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(152, 30);
            this.mskTelefon.TabIndex = 9;
            // 
            // mskHesap
            // 
            this.mskHesap.Enabled = false;
            this.mskHesap.Location = new System.Drawing.Point(168, 232);
            this.mskHesap.Mask = "000000";
            this.mskHesap.Name = "mskHesap";
            this.mskHesap.Size = new System.Drawing.Size(152, 30);
            this.mskHesap.TabIndex = 10;
            this.mskHesap.ValidatingType = typeof(int);
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(168, 276);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(152, 30);
            this.txSifre.TabIndex = 11;
            // 
            // btnKydet
            // 
            this.btnKydet.Location = new System.Drawing.Point(168, 326);
            this.btnKydet.Name = "btnKydet";
            this.btnKydet.Size = new System.Drawing.Size(152, 34);
            this.btnKydet.TabIndex = 12;
            this.btnKydet.Text = "Kaydet";
            this.btnKydet.UseVisualStyleBackColor = true;
            this.btnKydet.Click += new System.EventHandler(this.btnKydet_Click);
            // 
            // btnHesapGetir
            // 
            this.btnHesapGetir.Location = new System.Drawing.Point(326, 232);
            this.btnHesapGetir.Name = "btnHesapGetir";
            this.btnHesapGetir.Size = new System.Drawing.Size(42, 30);
            this.btnHesapGetir.TabIndex = 13;
            this.btnHesapGetir.Text = "...";
            this.btnHesapGetir.UseVisualStyleBackColor = true;
            this.btnHesapGetir.Click += new System.EventHandler(this.btnHesapGetir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(423, 442);
            this.Controls.Add(this.btnHesapGetir);
            this.Controls.Add(this.btnKydet);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.mskHesap);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.MaskedTextBox mskHesap;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Button btnKydet;
        private System.Windows.Forms.Button btnHesapGetir;
    }
}
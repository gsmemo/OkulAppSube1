namespace OkulAppSube1
{
    partial class frmogrkayıt
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
            this.grp_ogrencibilgileri = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_numara = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.grp_ogrencibilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ogrencibilgileri
            // 
            this.grp_ogrencibilgileri.Controls.Add(this.btn_kaydet);
            this.grp_ogrencibilgileri.Controls.Add(this.txt_numara);
            this.grp_ogrencibilgileri.Controls.Add(this.txt_soyad);
            this.grp_ogrencibilgileri.Controls.Add(this.txt_ad);
            this.grp_ogrencibilgileri.Controls.Add(this.lbl_numara);
            this.grp_ogrencibilgileri.Controls.Add(this.lbl_soyad);
            this.grp_ogrencibilgileri.Controls.Add(this.lbl_ad);
            this.grp_ogrencibilgileri.Location = new System.Drawing.Point(107, 53);
            this.grp_ogrencibilgileri.Name = "grp_ogrencibilgileri";
            this.grp_ogrencibilgileri.Size = new System.Drawing.Size(593, 284);
            this.grp_ogrencibilgileri.TabIndex = 0;
            this.grp_ogrencibilgileri.TabStop = false;
            this.grp_ogrencibilgileri.Text = "ogrencibilgileri";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(214, 208);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_numara
            // 
            this.txt_numara.Location = new System.Drawing.Point(400, 103);
            this.txt_numara.Name = "txt_numara";
            this.txt_numara.Size = new System.Drawing.Size(100, 22);
            this.txt_numara.TabIndex = 5;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(214, 103);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 22);
            this.txt_soyad.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(25, 103);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 22);
            this.txt_ad.TabIndex = 3;
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.Location = new System.Drawing.Point(437, 48);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(52, 16);
            this.lbl_numara.TabIndex = 2;
            this.lbl_numara.Text = "numara";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(236, 48);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(45, 16);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "soyad";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(51, 48);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 16);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "ad";
            // 
            // frmogrkayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_ogrencibilgileri);
            this.Name = "frmogrkayıt";
            this.Text = "ogrencikayıt";
            this.grp_ogrencibilgileri.ResumeLayout(false);
            this.grp_ogrencibilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ogrencibilgileri;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_numara;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
    }
}


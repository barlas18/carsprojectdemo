
namespace AracKiralamaOtomasyon.Formlar
{
    partial class frmHasarKayit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArac = new System.Windows.Forms.GroupBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMasraf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpMusteri.SuspendLayout();
            this.grpArac.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 164);
            this.dataGridView1.TabIndex = 10;
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.txtTelefon);
            this.grpMusteri.Controls.Add(this.label4);
            this.grpMusteri.Controls.Add(this.txtSoyad);
            this.grpMusteri.Controls.Add(this.label3);
            this.grpMusteri.Controls.Add(this.txtAd);
            this.grpMusteri.Controls.Add(this.label2);
            this.grpMusteri.Controls.Add(this.txtTc);
            this.grpMusteri.Controls.Add(this.label1);
            this.grpMusteri.Location = new System.Drawing.Point(6, 12);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(207, 198);
            this.grpMusteri.TabIndex = 11;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Bilgileri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(74, 139);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(74, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(74, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(74, 34);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 9;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C :";
            // 
            // grpArac
            // 
            this.grpArac.Controls.Add(this.txtPlaka);
            this.grpArac.Controls.Add(this.label9);
            this.grpArac.Controls.Add(this.txtModel);
            this.grpArac.Controls.Add(this.label5);
            this.grpArac.Controls.Add(this.txtSeri);
            this.grpArac.Controls.Add(this.label6);
            this.grpArac.Controls.Add(this.txtMarka);
            this.grpArac.Controls.Add(this.label7);
            this.grpArac.Location = new System.Drawing.Point(253, 12);
            this.grpArac.Name = "grpArac";
            this.grpArac.Size = new System.Drawing.Size(224, 198);
            this.grpArac.TabIndex = 12;
            this.grpArac.TabStop = false;
            this.grpArac.Text = "Araç Bilgisi";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(70, 34);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 22);
            this.txtPlaka.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Plaka:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(70, 132);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Model :";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(70, 97);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(100, 22);
            this.txtSeri.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Seri :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(70, 62);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Marka :";
            // 
            // txtMasraf
            // 
            this.txtMasraf.Location = new System.Drawing.Point(80, 231);
            this.txtMasraf.Name = "txtMasraf";
            this.txtMasraf.Size = new System.Drawing.Size(100, 22);
            this.txtMasraf.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Masraf :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(526, 39);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 37);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(526, 102);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 36);
            this.btnGeriDon.TabIndex = 14;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(323, 231);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(154, 22);
            this.txtAciklama.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Açıklama:";
            // 
            // frmHasarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 528);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMasraf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpArac);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHasarKayit";
            this.Text = "frmHasarKayit";
            this.Load += new System.EventHandler(this.frmHasarKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpArac.ResumeLayout(false);
            this.grpArac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArac;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMasraf;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label10;
    }
}
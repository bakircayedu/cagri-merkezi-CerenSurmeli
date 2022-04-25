
namespace ÖdevBaslangic
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
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.rbtnTicariTemsilci1 = new System.Windows.Forms.RadioButton();
            this.rbtnTicariTemsilci2 = new System.Windows.Forms.RadioButton();
            this.rbtnBireyselTemsilci1 = new System.Windows.Forms.RadioButton();
            this.rbtnBireyselTemsilci2 = new System.Windows.Forms.RadioButton();
            this.btnCagriyiAta = new System.Windows.Forms.Button();
            this.rbtnBireyselMusteri = new System.Windows.Forms.RadioButton();
            this.rbtnTicariMusteri = new System.Windows.Forms.RadioButton();
            this.lblMusteriTuru = new System.Windows.Forms.Label();
            this.grpboxMusteriTemsilcileri = new System.Windows.Forms.GroupBox();
            this.btnCagriyiBitir = new System.Windows.Forms.Button();
            this.grpboxAramaEkrani = new System.Windows.Forms.GroupBox();
            this.CagriList = new System.Windows.Forms.ListBox();
            this.grpboxMusteriTemsilcileri.SuspendLayout();
            this.grpboxAramaEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMusteriID.Location = new System.Drawing.Point(31, 66);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(257, 27);
            this.txtMusteriID.TabIndex = 4;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(31, 30);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(257, 20);
            this.lblMusteriID.TabIndex = 5;
            this.lblMusteriID.Text = "Arama Yapmak İçin Müşteri ID Giriniz:";
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(56, 229);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(94, 29);
            this.btnAramaYap.TabIndex = 6;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // rbtnTicariTemsilci1
            // 
            this.rbtnTicariTemsilci1.AutoSize = true;
            this.rbtnTicariTemsilci1.Location = new System.Drawing.Point(17, 30);
            this.rbtnTicariTemsilci1.Name = "rbtnTicariTemsilci1";
            this.rbtnTicariTemsilci1.Size = new System.Drawing.Size(198, 24);
            this.rbtnTicariTemsilci1.TabIndex = 7;
            this.rbtnTicariTemsilci1.Text = "Ticari Müşteri Temsilcisi 1";
            this.rbtnTicariTemsilci1.UseVisualStyleBackColor = true;
            // 
            // rbtnTicariTemsilci2
            // 
            this.rbtnTicariTemsilci2.AutoSize = true;
            this.rbtnTicariTemsilci2.Location = new System.Drawing.Point(17, 86);
            this.rbtnTicariTemsilci2.Name = "rbtnTicariTemsilci2";
            this.rbtnTicariTemsilci2.Size = new System.Drawing.Size(198, 24);
            this.rbtnTicariTemsilci2.TabIndex = 8;
            this.rbtnTicariTemsilci2.Text = "Ticari Müşteri Temsilcisi 2";
            this.rbtnTicariTemsilci2.UseVisualStyleBackColor = true;
            // 
            // rbtnBireyselTemsilci1
            // 
            this.rbtnBireyselTemsilci1.AutoSize = true;
            this.rbtnBireyselTemsilci1.Location = new System.Drawing.Point(17, 141);
            this.rbtnBireyselTemsilci1.Name = "rbtnBireyselTemsilci1";
            this.rbtnBireyselTemsilci1.Size = new System.Drawing.Size(213, 24);
            this.rbtnBireyselTemsilci1.TabIndex = 9;
            this.rbtnBireyselTemsilci1.Text = "Bireysel Müşteri Temsilcisi 1";
            this.rbtnBireyselTemsilci1.UseVisualStyleBackColor = true;
            // 
            // rbtnBireyselTemsilci2
            // 
            this.rbtnBireyselTemsilci2.AutoSize = true;
            this.rbtnBireyselTemsilci2.Location = new System.Drawing.Point(17, 195);
            this.rbtnBireyselTemsilci2.Name = "rbtnBireyselTemsilci2";
            this.rbtnBireyselTemsilci2.Size = new System.Drawing.Size(213, 24);
            this.rbtnBireyselTemsilci2.TabIndex = 10;
            this.rbtnBireyselTemsilci2.Text = "Bireysel Müşteri Temsilcisi 2";
            this.rbtnBireyselTemsilci2.UseVisualStyleBackColor = true;
            // 
            // btnCagriyiAta
            // 
            this.btnCagriyiAta.Location = new System.Drawing.Point(17, 229);
            this.btnCagriyiAta.Name = "btnCagriyiAta";
            this.btnCagriyiAta.Size = new System.Drawing.Size(94, 29);
            this.btnCagriyiAta.TabIndex = 11;
            this.btnCagriyiAta.Text = "Çağrıyı Ata";
            this.btnCagriyiAta.UseVisualStyleBackColor = true;
            this.btnCagriyiAta.Click += new System.EventHandler(this.btnCagriyiAta_Click);
            // 
            // rbtnBireyselMusteri
            // 
            this.rbtnBireyselMusteri.AutoSize = true;
            this.rbtnBireyselMusteri.Location = new System.Drawing.Point(31, 183);
            this.rbtnBireyselMusteri.Name = "rbtnBireyselMusteri";
            this.rbtnBireyselMusteri.Size = new System.Drawing.Size(134, 24);
            this.rbtnBireyselMusteri.TabIndex = 13;
            this.rbtnBireyselMusteri.TabStop = true;
            this.rbtnBireyselMusteri.Text = "Bireysel Müşteri";
            this.rbtnBireyselMusteri.UseVisualStyleBackColor = true;
            // 
            // rbtnTicariMusteri
            // 
            this.rbtnTicariMusteri.AutoSize = true;
            this.rbtnTicariMusteri.Location = new System.Drawing.Point(31, 153);
            this.rbtnTicariMusteri.Name = "rbtnTicariMusteri";
            this.rbtnTicariMusteri.Size = new System.Drawing.Size(119, 24);
            this.rbtnTicariMusteri.TabIndex = 12;
            this.rbtnTicariMusteri.TabStop = true;
            this.rbtnTicariMusteri.Text = "Ticari Müşteri";
            this.rbtnTicariMusteri.UseVisualStyleBackColor = true;
            // 
            // lblMusteriTuru
            // 
            this.lblMusteriTuru.AutoSize = true;
            this.lblMusteriTuru.Location = new System.Drawing.Point(31, 113);
            this.lblMusteriTuru.Name = "lblMusteriTuru";
            this.lblMusteriTuru.Size = new System.Drawing.Size(227, 20);
            this.lblMusteriTuru.TabIndex = 14;
            this.lblMusteriTuru.Text = "Lütfen Müşteri Türü Seçimi Yapın.";
            // 
            // grpboxMusteriTemsilcileri
            // 
            this.grpboxMusteriTemsilcileri.Controls.Add(this.btnCagriyiBitir);
            this.grpboxMusteriTemsilcileri.Controls.Add(this.rbtnTicariTemsilci2);
            this.grpboxMusteriTemsilcileri.Controls.Add(this.rbtnTicariTemsilci1);
            this.grpboxMusteriTemsilcileri.Controls.Add(this.btnCagriyiAta);
            this.grpboxMusteriTemsilcileri.Controls.Add(this.rbtnBireyselTemsilci1);
            this.grpboxMusteriTemsilcileri.Controls.Add(this.rbtnBireyselTemsilci2);
            this.grpboxMusteriTemsilcileri.Location = new System.Drawing.Point(386, 31);
            this.grpboxMusteriTemsilcileri.Name = "grpboxMusteriTemsilcileri";
            this.grpboxMusteriTemsilcileri.Size = new System.Drawing.Size(260, 288);
            this.grpboxMusteriTemsilcileri.TabIndex = 15;
            this.grpboxMusteriTemsilcileri.TabStop = false;
            this.grpboxMusteriTemsilcileri.Text = "Musteri Temsilcileri";
            // 
            // btnCagriyiBitir
            // 
            this.btnCagriyiBitir.Location = new System.Drawing.Point(136, 229);
            this.btnCagriyiBitir.Name = "btnCagriyiBitir";
            this.btnCagriyiBitir.Size = new System.Drawing.Size(94, 29);
            this.btnCagriyiBitir.TabIndex = 12;
            this.btnCagriyiBitir.Text = "Çağrıyı Bitir";
            this.btnCagriyiBitir.UseVisualStyleBackColor = true;
            this.btnCagriyiBitir.Click += new System.EventHandler(this.btnCagriyiBitir_Click);
            // 
            // grpboxAramaEkrani
            // 
            this.grpboxAramaEkrani.Controls.Add(this.txtMusteriID);
            this.grpboxAramaEkrani.Controls.Add(this.lblMusteriID);
            this.grpboxAramaEkrani.Controls.Add(this.btnAramaYap);
            this.grpboxAramaEkrani.Controls.Add(this.lblMusteriTuru);
            this.grpboxAramaEkrani.Controls.Add(this.rbtnBireyselMusteri);
            this.grpboxAramaEkrani.Controls.Add(this.rbtnTicariMusteri);
            this.grpboxAramaEkrani.Location = new System.Drawing.Point(26, 31);
            this.grpboxAramaEkrani.Name = "grpboxAramaEkrani";
            this.grpboxAramaEkrani.Size = new System.Drawing.Size(326, 288);
            this.grpboxAramaEkrani.TabIndex = 16;
            this.grpboxAramaEkrani.TabStop = false;
            this.grpboxAramaEkrani.Text = "Arama Ekranı";
            // 
            // CagriList
            // 
            this.CagriList.FormattingEnabled = true;
            this.CagriList.ItemHeight = 20;
            this.CagriList.Location = new System.Drawing.Point(717, 39);
            this.CagriList.Name = "CagriList";
            this.CagriList.Size = new System.Drawing.Size(329, 404);
            this.CagriList.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 576);
            this.Controls.Add(this.CagriList);
            this.Controls.Add(this.grpboxAramaEkrani);
            this.Controls.Add(this.grpboxMusteriTemsilcileri);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxMusteriTemsilcileri.ResumeLayout(false);
            this.grpboxMusteriTemsilcileri.PerformLayout();
            this.grpboxAramaEkrani.ResumeLayout(false);
            this.grpboxAramaEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.RadioButton rbtnTicariTemsilci1;
        private System.Windows.Forms.RadioButton rbtnTicariTemsilci2;
        private System.Windows.Forms.RadioButton rbtnBireyselTemsilci1;
        private System.Windows.Forms.RadioButton rbtnBireyselTemsilci2;
        private System.Windows.Forms.Button btnCagriyiAta;
        private System.Windows.Forms.RadioButton rbtnBireyselMusteri;
        private System.Windows.Forms.RadioButton rbtnTicariMusteri;
        private System.Windows.Forms.Label lblMusteriTuru;
        private System.Windows.Forms.GroupBox grpboxMusteriTemsilcileri;
        private System.Windows.Forms.GroupBox grpboxAramaEkrani;
        private System.Windows.Forms.Button btnCagriyiBitir;
        private System.Windows.Forms.ListBox CagriList;
    }
}


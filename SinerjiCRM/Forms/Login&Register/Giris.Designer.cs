﻿namespace SinerjiCRM
{
    partial class Giris
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiris = new Button();
            btnCikis = new Button();
            cbSifre = new CheckBox();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.Top;
            txtKullaniciAdi.Font = new Font("Segoe UI", 9F);
            txtKullaniciAdi.Location = new Point(133, 58);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(258, 23);
            txtKullaniciAdi.TabIndex = 36;
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.Top;
            txtSifre.Font = new Font("Segoe UI", 9F);
            txtSifre.Location = new Point(133, 98);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(258, 23);
            txtSifre.TabIndex = 37;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 38;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(90, 106);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 39;
            label2.Text = "Şifre";
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.Top;
            btnGiris.Location = new Point(181, 165);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 63;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top;
            btnCikis.Location = new Point(224, 194);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 23);
            btnCikis.TabIndex = 64;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // cbSifre
            // 
            cbSifre.Anchor = AnchorStyles.Top;
            cbSifre.AutoSize = true;
            cbSifre.Location = new Point(297, 127);
            cbSifre.Name = "cbSifre";
            cbSifre.Size = new Size(94, 19);
            cbSifre.TabIndex = 65;
            cbSifre.Text = "Şifreyi göster";
            cbSifre.UseVisualStyleBackColor = true;
            cbSifre.CheckStateChanged += cbSifre_CheckStateChanged;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(262, 165);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(75, 23);
            btnKayitOl.TabIndex = 66;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(504, 261);
            Controls.Add(btnKayitOl);
            Controls.Add(cbSifre);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            KeyPreview = true;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            KeyDown += btnGiris_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private Button btnGiris;
        private Button btnCikis;
        private CheckBox cbSifre;
        private Button btnKayitOl;
    }
}
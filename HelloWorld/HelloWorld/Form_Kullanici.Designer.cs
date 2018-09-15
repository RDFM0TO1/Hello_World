namespace HelloWorld
{
    partial class Form_Kullanici
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
            this.textE_Kul_Ad = new DevExpress.XtraEditors.TextEdit();
            this.textE_Kul_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleB_Kul_Giris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Kul_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Kul_Sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(523, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textE_Kul_Ad
            // 
            this.textE_Kul_Ad.Location = new System.Drawing.Point(643, 138);
            this.textE_Kul_Ad.Name = "textE_Kul_Ad";
            this.textE_Kul_Ad.Size = new System.Drawing.Size(121, 22);
            this.textE_Kul_Ad.TabIndex = 1;
            // 
            // textE_Kul_Sifre
            // 
            this.textE_Kul_Sifre.Location = new System.Drawing.Point(643, 187);
            this.textE_Kul_Sifre.Name = "textE_Kul_Sifre";
            this.textE_Kul_Sifre.Size = new System.Drawing.Size(121, 22);
            this.textE_Kul_Sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(587, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // simpleB_Kul_Giris
            // 
            this.simpleB_Kul_Giris.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.simpleB_Kul_Giris.Appearance.Options.UseFont = true;
            this.simpleB_Kul_Giris.Location = new System.Drawing.Point(643, 231);
            this.simpleB_Kul_Giris.Name = "simpleB_Kul_Giris";
            this.simpleB_Kul_Giris.Size = new System.Drawing.Size(121, 59);
            this.simpleB_Kul_Giris.TabIndex = 4;
            this.simpleB_Kul_Giris.Text = "Giriş";
            this.simpleB_Kul_Giris.Click += new System.EventHandler(this.simpleB_Kul_Giris_Click);
            // 
            // Form_Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelloWorld.Properties.Resources.yeniadmin2;
            this.ClientSize = new System.Drawing.Size(849, 542);
            this.Controls.Add(this.simpleB_Kul_Giris);
            this.Controls.Add(this.textE_Kul_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textE_Kul_Ad);
            this.Controls.Add(this.label1);
            this.Name = "Form_Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GİRİŞ PANELİ";
            this.Load += new System.EventHandler(this.Form_Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textE_Kul_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Kul_Sifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textE_Kul_Ad;
        private DevExpress.XtraEditors.TextEdit textE_Kul_Sifre;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleB_Kul_Giris;
    }
}
namespace HelloWorld
{
    partial class Form_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mail));
            this.label_Mail = new System.Windows.Forms.Label();
            this.textE_Mail_Mail = new DevExpress.XtraEditors.TextEdit();
            this.textE_Mail_Konu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.richT_Mail_Mesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleB_Mail_Gönder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Mail_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Mail_Konu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.BackColor = System.Drawing.Color.Transparent;
            this.label_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mail.ForeColor = System.Drawing.Color.Cornsilk;
            this.label_Mail.Location = new System.Drawing.Point(20, 95);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(108, 24);
            this.label_Mail.TabIndex = 0;
            this.label_Mail.Text = "Mail Adresi:";
            // 
            // textE_Mail_Mail
            // 
            this.textE_Mail_Mail.Location = new System.Drawing.Point(134, 92);
            this.textE_Mail_Mail.Name = "textE_Mail_Mail";
            this.textE_Mail_Mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Mail_Mail.Properties.Appearance.Options.UseFont = true;
            this.textE_Mail_Mail.Size = new System.Drawing.Size(336, 28);
            this.textE_Mail_Mail.TabIndex = 1;
            // 
            // textE_Mail_Konu
            // 
            this.textE_Mail_Konu.Location = new System.Drawing.Point(134, 136);
            this.textE_Mail_Konu.Name = "textE_Mail_Konu";
            this.textE_Mail_Konu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Mail_Konu.Properties.Appearance.Options.UseFont = true;
            this.textE_Mail_Konu.Size = new System.Drawing.Size(336, 28);
            this.textE_Mail_Konu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(68, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konu:";
            // 
            // richT_Mail_Mesaj
            // 
            this.richT_Mail_Mesaj.Location = new System.Drawing.Point(134, 192);
            this.richT_Mail_Mesaj.Name = "richT_Mail_Mesaj";
            this.richT_Mail_Mesaj.Size = new System.Drawing.Size(336, 291);
            this.richT_Mail_Mesaj.TabIndex = 4;
            this.richT_Mail_Mesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(63, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesaj:";
            // 
            // simpleB_Mail_Gönder
            // 
            this.simpleB_Mail_Gönder.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Mail_Gönder.Appearance.Options.UseFont = true;
            this.simpleB_Mail_Gönder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleB_Mail_Gönder.Location = new System.Drawing.Point(230, 515);
            this.simpleB_Mail_Gönder.Name = "simpleB_Mail_Gönder";
            this.simpleB_Mail_Gönder.Size = new System.Drawing.Size(123, 54);
            this.simpleB_Mail_Gönder.TabIndex = 6;
            this.simpleB_Mail_Gönder.Text = "Gönder";
            this.simpleB_Mail_Gönder.Click += new System.EventHandler(this.simpleB_Mail_Gönder_Click);
            // 
            // Form_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(508, 581);
            this.Controls.Add(this.simpleB_Mail_Gönder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richT_Mail_Mesaj);
            this.Controls.Add(this.textE_Mail_Konu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textE_Mail_Mail);
            this.Controls.Add(this.label_Mail);
            this.Name = "Form_Mail";
            this.Text = "Form_Mail";
            this.Load += new System.EventHandler(this.Form_Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textE_Mail_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Mail_Konu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Mail;
        private DevExpress.XtraEditors.TextEdit textE_Mail_Mail;
        private DevExpress.XtraEditors.TextEdit textE_Mail_Konu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richT_Mail_Mesaj;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleB_Mail_Gönder;
    }
}
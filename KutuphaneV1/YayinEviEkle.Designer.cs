namespace KutuphaneV1
{
    partial class YayinEviEkle
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
            this.btnYayinEviIptal = new System.Windows.Forms.Button();
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYayinEviIptal
            // 
            this.btnYayinEviIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEviIptal.Location = new System.Drawing.Point(438, 119);
            this.btnYayinEviIptal.Name = "btnYayinEviIptal";
            this.btnYayinEviIptal.Size = new System.Drawing.Size(184, 44);
            this.btnYayinEviIptal.TabIndex = 11;
            this.btnYayinEviIptal.Text = "Vazgeç";
            this.btnYayinEviIptal.UseVisualStyleBackColor = true;
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEviEkle.Location = new System.Drawing.Point(199, 119);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(174, 44);
            this.btnYayinEviEkle.TabIndex = 10;
            this.btnYayinEviEkle.Text = "Kaydet";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // txtYayinEviAdi
            // 
            this.txtYayinEviAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEviAdi.Location = new System.Drawing.Point(186, 55);
            this.txtYayinEviAdi.Name = "txtYayinEviAdi";
            this.txtYayinEviAdi.Size = new System.Drawing.Size(436, 36);
            this.txtYayinEviAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yayın Evi Adı";
            // 
            // YayinEviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 215);
            this.Controls.Add(this.btnYayinEviIptal);
            this.Controls.Add(this.btnYayinEviEkle);
            this.Controls.Add(this.txtYayinEviAdi);
            this.Controls.Add(this.label1);
            this.Name = "YayinEviEkle";
            this.Text = "YayinEviEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYayinEviIptal;
        private System.Windows.Forms.Button btnYayinEviEkle;
        private System.Windows.Forms.TextBox txtYayinEviAdi;
        private System.Windows.Forms.Label label1;
    }
}
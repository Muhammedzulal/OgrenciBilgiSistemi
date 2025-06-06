namespace OgrenciBilgiSistemi
{
    partial class TeacherScreenMain
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
            this.btnNotGiris = new System.Windows.Forms.Button();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotGiris
            // 
            this.btnNotGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnNotGiris.Location = new System.Drawing.Point(143, 244);
            this.btnNotGiris.Name = "btnNotGiris";
            this.btnNotGiris.Size = new System.Drawing.Size(255, 61);
            this.btnNotGiris.TabIndex = 0;
            this.btnNotGiris.Text = "Not Giriş";
            this.btnNotGiris.UseVisualStyleBackColor = true;
            this.btnNotGiris.Click += new System.EventHandler(this.btnNotGiris_Click);
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnOgrenciKayit.Location = new System.Drawing.Point(143, 177);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(255, 61);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "Öğrenci Kayıt";
            this.btnOgrenciKayit.UseVisualStyleBackColor = true;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 45);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TeacherScreenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 471);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.btnNotGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeacherScreenMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherScreenMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotGiris;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnBack;
    }
}
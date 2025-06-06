namespace OgrenciBilgiSistemi
{
    partial class DersKayit
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
            this.dgwDersler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKesinlestir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxSecilenler = new System.Windows.Forms.GroupBox();
            this.lblDersler = new System.Windows.Forms.Label();
            this.btnDersSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).BeginInit();
            this.grpBoxSecilenler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDersler
            // 
            this.dgwDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDersler.Location = new System.Drawing.Point(36, 73);
            this.dgwDersler.Name = "dgwDersler";
            this.dgwDersler.RowHeadersWidth = 51;
            this.dgwDersler.RowTemplate.Height = 24;
            this.dgwDersler.Size = new System.Drawing.Size(598, 202);
            this.dgwDersler.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MistyRose;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(36, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 63);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Dersi Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKesinlestir
            // 
            this.btnKesinlestir.BackColor = System.Drawing.Color.MistyRose;
            this.btnKesinlestir.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnKesinlestir.Location = new System.Drawing.Point(36, 435);
            this.btnKesinlestir.Name = "btnKesinlestir";
            this.btnKesinlestir.Size = new System.Drawing.Size(180, 63);
            this.btnKesinlestir.TabIndex = 3;
            this.btnKesinlestir.Text = "Kesinleştir";
            this.btnKesinlestir.UseVisualStyleBackColor = false;
            this.btnKesinlestir.Click += new System.EventHandler(this.btnKesinlestir_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(36, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(219, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxSecilenler
            // 
            this.grpBoxSecilenler.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxSecilenler.Controls.Add(this.lblDersler);
            this.grpBoxSecilenler.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxSecilenler.Location = new System.Drawing.Point(241, 296);
            this.grpBoxSecilenler.Name = "grpBoxSecilenler";
            this.grpBoxSecilenler.Size = new System.Drawing.Size(393, 202);
            this.grpBoxSecilenler.TabIndex = 5;
            this.grpBoxSecilenler.TabStop = false;
            this.grpBoxSecilenler.Text = "Seçilen Dersler";
            // 
            // lblDersler
            // 
            this.lblDersler.AutoSize = true;
            this.lblDersler.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDersler.Location = new System.Drawing.Point(6, 21);
            this.lblDersler.Name = "lblDersler";
            this.lblDersler.Size = new System.Drawing.Size(136, 31);
            this.lblDersler.TabIndex = 0;
            this.lblDersler.Text = "Secilecekler";
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.MistyRose;
            this.btnDersSil.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDersSil.Location = new System.Drawing.Point(36, 365);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(180, 63);
            this.btnDersSil.TabIndex = 6;
            this.btnDersSil.Text = "Sıfırla";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // DersKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 510);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.grpBoxSecilenler);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKesinlestir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwDersler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DersKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DersKayit";
            this.Load += new System.EventHandler(this.DersKayit_Load);
            this.Shown += new System.EventHandler(this.DersKayit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).EndInit();
            this.grpBoxSecilenler.ResumeLayout(false);
            this.grpBoxSecilenler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDersler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKesinlestir;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxSecilenler;
        private System.Windows.Forms.Label lblDersler;
        private System.Windows.Forms.Button btnDersSil;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class NotGiris
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.grpBoxDersler = new System.Windows.Forms.GroupBox();
            this.btnNotGir = new System.Windows.Forms.Button();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxDersler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtBoxNo.Location = new System.Drawing.Point(9, 79);
            this.txtBoxNo.MaxLength = 9;
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(306, 36);
            this.txtBoxNo.TabIndex = 1;
            this.txtBoxNo.Enter += new System.EventHandler(this.txtBoxNo_Enter);
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBoxInfo.Controls.Add(this.lblInfo);
            this.grpBoxInfo.Location = new System.Drawing.Point(335, 79);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(304, 457);
            this.grpBoxInfo.TabIndex = 3;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Öğrenci Bilgileri";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(7, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 30);
            this.lblInfo.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(7, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Ders 1";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(7, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Ders 2";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(7, 135);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 20);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Ders 3";
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4.Location = new System.Drawing.Point(7, 185);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(51, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Ders 4";
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.Location = new System.Drawing.Point(7, 235);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(51, 20);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Ders 5";
            this.lbl5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(94, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(94, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 30);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(94, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 30);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(94, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 30);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(94, 228);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 30);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.MistyRose;
            this.btnGetir.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnGetir.Location = new System.Drawing.Point(9, 131);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(306, 43);
            this.btnGetir.TabIndex = 14;
            this.btnGetir.Text = "Öğrenciyi Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // grpBoxDersler
            // 
            this.grpBoxDersler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBoxDersler.Controls.Add(this.btnNotGir);
            this.grpBoxDersler.Controls.Add(this.lbl1);
            this.grpBoxDersler.Controls.Add(this.lbl2);
            this.grpBoxDersler.Controls.Add(this.textBox5);
            this.grpBoxDersler.Controls.Add(this.lbl3);
            this.grpBoxDersler.Controls.Add(this.textBox4);
            this.grpBoxDersler.Controls.Add(this.lbl4);
            this.grpBoxDersler.Controls.Add(this.textBox3);
            this.grpBoxDersler.Controls.Add(this.lbl5);
            this.grpBoxDersler.Controls.Add(this.textBox2);
            this.grpBoxDersler.Controls.Add(this.textBox1);
            this.grpBoxDersler.Location = new System.Drawing.Point(4, 203);
            this.grpBoxDersler.Name = "grpBoxDersler";
            this.grpBoxDersler.Size = new System.Drawing.Size(311, 333);
            this.grpBoxDersler.TabIndex = 15;
            this.grpBoxDersler.TabStop = false;
            this.grpBoxDersler.Text = "Dersler";
            // 
            // btnNotGir
            // 
            this.btnNotGir.BackColor = System.Drawing.Color.MistyRose;
            this.btnNotGir.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnNotGir.Location = new System.Drawing.Point(11, 275);
            this.btnNotGir.Name = "btnNotGir";
            this.btnNotGir.Size = new System.Drawing.Size(259, 40);
            this.btnNotGir.TabIndex = 14;
            this.btnNotGir.Text = "Notları Gir";
            this.btnNotGir.UseVisualStyleBackColor = false;
            this.btnNotGir.Click += new System.EventHandler(this.btnNotGir_Click);
            // 
            // NotGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 558);
            this.Controls.Add(this.grpBoxDersler);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.txtBoxNo);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NotGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotGiris";
            this.Load += new System.EventHandler(this.NotGiris_Load);
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.grpBoxDersler.ResumeLayout(false);
            this.grpBoxDersler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxNo;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.GroupBox grpBoxDersler;
        private System.Windows.Forms.Button btnNotGir;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class OgrenciKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.txtBoxBirthDate = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxDeleteNo = new System.Windows.Forms.TextBox();
            this.lblDeleteNo = new System.Windows.Forms.Label();
            this.grpBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.grpBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(0, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Adı :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(0, 50);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(70, 23);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Soyadı :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(0, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email :";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.Location = new System.Drawing.Point(0, 110);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(121, 23);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Doğum Tarihi :";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNo.Location = new System.Drawing.Point(0, 140);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(74, 23);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "Telefon :";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(0, 170);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(81, 23);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "Numara :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(0, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Şifre :";
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.txtBoxPassword);
            this.grpBoxInfo.Controls.Add(this.btnRegister);
            this.grpBoxInfo.Controls.Add(this.txtBoxNo);
            this.grpBoxInfo.Controls.Add(this.txtBoxPhoneNo);
            this.grpBoxInfo.Controls.Add(this.txtBoxBirthDate);
            this.grpBoxInfo.Controls.Add(this.txtBoxEmail);
            this.grpBoxInfo.Controls.Add(this.txtBoxSurname);
            this.grpBoxInfo.Controls.Add(this.txtBoxName);
            this.grpBoxInfo.Controls.Add(this.lblName);
            this.grpBoxInfo.Controls.Add(this.lblPassword);
            this.grpBoxInfo.Controls.Add(this.lblSurname);
            this.grpBoxInfo.Controls.Add(this.lblNo);
            this.grpBoxInfo.Controls.Add(this.lblEmail);
            this.grpBoxInfo.Controls.Add(this.lblPhoneNo);
            this.grpBoxInfo.Controls.Add(this.lblBirthDate);
            this.grpBoxInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxInfo.Location = new System.Drawing.Point(6, 66);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(386, 305);
            this.grpBoxInfo.TabIndex = 7;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Kayıt Bilgileri";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPassword.Location = new System.Drawing.Point(142, 200);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(238, 27);
            this.txtBoxPassword.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MistyRose;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(10, 242);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(370, 44);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Öğrenciyi Kaydet";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxNo.Location = new System.Drawing.Point(142, 170);
            this.txtBoxNo.MaxLength = 9;
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(238, 27);
            this.txtBoxNo.TabIndex = 12;
            // 
            // txtBoxPhoneNo
            // 
            this.txtBoxPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPhoneNo.Location = new System.Drawing.Point(142, 140);
            this.txtBoxPhoneNo.Name = "txtBoxPhoneNo";
            this.txtBoxPhoneNo.Size = new System.Drawing.Size(238, 27);
            this.txtBoxPhoneNo.TabIndex = 11;
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxBirthDate.Location = new System.Drawing.Point(142, 110);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.Size = new System.Drawing.Size(238, 27);
            this.txtBoxBirthDate.TabIndex = 10;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxEmail.Location = new System.Drawing.Point(142, 80);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(238, 27);
            this.txtBoxEmail.TabIndex = 9;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSurname.Location = new System.Drawing.Point(142, 50);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(238, 27);
            this.txtBoxSurname.TabIndex = 8;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxName.Location = new System.Drawing.Point(142, 20);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(238, 27);
            this.txtBoxName.TabIndex = 7;
            // 
            // dgwStudents
            // 
            this.dgwStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStudents.Location = new System.Drawing.Point(398, 66);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 30;
            this.dgwStudents.Size = new System.Drawing.Size(694, 305);
            this.dgwStudents.TabIndex = 8;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(6, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 37);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxDelete
            // 
            this.grpBoxDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpBoxDelete.Controls.Add(this.btnDelete);
            this.grpBoxDelete.Controls.Add(this.txtBoxDeleteNo);
            this.grpBoxDelete.Controls.Add(this.lblDeleteNo);
            this.grpBoxDelete.Location = new System.Drawing.Point(6, 408);
            this.grpBoxDelete.Name = "grpBoxDelete";
            this.grpBoxDelete.Size = new System.Drawing.Size(380, 144);
            this.grpBoxDelete.TabIndex = 11;
            this.grpBoxDelete.TabStop = false;
            this.grpBoxDelete.Text = "Kayıt Silme";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(12, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(347, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Öğrenciyi Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxDeleteNo
            // 
            this.txtBoxDeleteNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDeleteNo.Location = new System.Drawing.Point(105, 31);
            this.txtBoxDeleteNo.Name = "txtBoxDeleteNo";
            this.txtBoxDeleteNo.Size = new System.Drawing.Size(252, 31);
            this.txtBoxDeleteNo.TabIndex = 2;
            // 
            // lblDeleteNo
            // 
            this.lblDeleteNo.AutoSize = true;
            this.lblDeleteNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeleteNo.Location = new System.Drawing.Point(6, 29);
            this.lblDeleteNo.Name = "lblDeleteNo";
            this.lblDeleteNo.Size = new System.Drawing.Size(58, 31);
            this.lblDeleteNo.TabIndex = 1;
            this.lblDeleteNo.Text = "No :";
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 562);
            this.Controls.Add(this.grpBoxDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwStudents);
            this.Controls.Add(this.grpBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciKayit";
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.grpBoxDelete.ResumeLayout(false);
            this.grpBoxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxNo;
        private System.Windows.Forms.TextBox txtBoxPhoneNo;
        private System.Windows.Forms.TextBox txtBoxBirthDate;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxDelete;
        private System.Windows.Forms.Label lblDeleteNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxDeleteNo;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class StudentScreenMain
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
            this.studentPropsLbl = new System.Windows.Forms.Label();
            this.studentNoteLbl = new System.Windows.Forms.Label();
            this.subjectRegisterBtn = new System.Windows.Forms.Button();
            this.transcriptBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentPropsLbl
            // 
            this.studentPropsLbl.AutoSize = true;
            this.studentPropsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentPropsLbl.Location = new System.Drawing.Point(12, 77);
            this.studentPropsLbl.Name = "studentPropsLbl";
            this.studentPropsLbl.Size = new System.Drawing.Size(224, 31);
            this.studentPropsLbl.TabIndex = 0;
            this.studentPropsLbl.Text = "NONAMESURNAME";
            // 
            // studentNoteLbl
            // 
            this.studentNoteLbl.AutoSize = true;
            this.studentNoteLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.studentNoteLbl.Location = new System.Drawing.Point(488, 77);
            this.studentNoteLbl.Name = "studentNoteLbl";
            this.studentNoteLbl.Size = new System.Drawing.Size(80, 31);
            this.studentNoteLbl.TabIndex = 1;
            this.studentNoteLbl.Text = "AGNO";
            // 
            // subjectRegisterBtn
            // 
            this.subjectRegisterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.subjectRegisterBtn.Location = new System.Drawing.Point(167, 217);
            this.subjectRegisterBtn.Name = "subjectRegisterBtn";
            this.subjectRegisterBtn.Size = new System.Drawing.Size(303, 68);
            this.subjectRegisterBtn.TabIndex = 2;
            this.subjectRegisterBtn.Text = "Ders Kayıt";
            this.subjectRegisterBtn.UseVisualStyleBackColor = true;
            this.subjectRegisterBtn.Click += new System.EventHandler(this.subjectRegisterBtn_Click);
            // 
            // transcriptBtn
            // 
            this.transcriptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.transcriptBtn.Location = new System.Drawing.Point(167, 291);
            this.transcriptBtn.Name = "transcriptBtn";
            this.transcriptBtn.Size = new System.Drawing.Size(303, 68);
            this.transcriptBtn.TabIndex = 3;
            this.transcriptBtn.Text = "Transkript Yazdır";
            this.transcriptBtn.UseVisualStyleBackColor = true;
            this.transcriptBtn.Click += new System.EventHandler(this.transcriptBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(18, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StudentScreenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 525);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.transcriptBtn);
            this.Controls.Add(this.subjectRegisterBtn);
            this.Controls.Add(this.studentNoteLbl);
            this.Controls.Add(this.studentPropsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentScreenMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentScreenMain";
            this.Load += new System.EventHandler(this.StudentScreenMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentPropsLbl;
        private System.Windows.Forms.Label studentNoteLbl;
        private System.Windows.Forms.Button subjectRegisterBtn;
        private System.Windows.Forms.Button transcriptBtn;
        private System.Windows.Forms.Button btnBack;
    }
}
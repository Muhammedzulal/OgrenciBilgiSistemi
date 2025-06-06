namespace OgrenciBilgiSistemi
{
    partial class TranscriptScreen
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
            this.lblNo = new System.Windows.Forms.Label();
            this.lblAgno = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxNotes = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpBoxNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(12, 65);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(39, 28);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "No";
            // 
            // lblAgno
            // 
            this.lblAgno.AutoSize = true;
            this.lblAgno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAgno.Location = new System.Drawing.Point(13, 98);
            this.lblAgno.Name = "lblAgno";
            this.lblAgno.Size = new System.Drawing.Size(69, 28);
            this.lblAgno.TabIndex = 2;
            this.lblAgno.Text = "AGNO";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxNotes
            // 
            this.grpBoxNotes.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxNotes.Controls.Add(this.lblNotes);
            this.grpBoxNotes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxNotes.Location = new System.Drawing.Point(12, 142);
            this.grpBoxNotes.Name = "grpBoxNotes";
            this.grpBoxNotes.Size = new System.Drawing.Size(272, 358);
            this.grpBoxNotes.TabIndex = 4;
            this.grpBoxNotes.TabStop = false;
            this.grpBoxNotes.Text = "Notlar";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(6, 27);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(0, 28);
            this.lblNotes.TabIndex = 0;
            // 
            // TranscriptScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 523);
            this.Controls.Add(this.grpBoxNotes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAgno);
            this.Controls.Add(this.lblNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TranscriptScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranscriptScreen";
            this.Load += new System.EventHandler(this.TranscriptScreen_Load);
            this.grpBoxNotes.ResumeLayout(false);
            this.grpBoxNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblAgno;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}
using OgrenciBilgiSistemi.Ogrenci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciBilgiSistemi
{
    public partial class TranscriptScreen : Form
    {
        string _userName;
        Note _note =new Note();
        public TranscriptScreen(string UserName)
        {
            this.MaximizeBox = false;
            _userName = UserName;
            InitializeComponent();
           

        }

        private void TranscriptScreen_Load(object sender, EventArgs e)
        {
          
            lblNo.Text = "No: "+_userName;
            lblAgno.Text = "AGNO: "+_note.GetNote(_userName).ToString("0.00");
            string [] notes = _note.GetAllNotes(_userName);
            for (int i = 1; i < notes.Length; i++)
            {
                lblNotes.Text += notes[i];
                if (i % 2 == 0)
                {
                    lblNotes.Text+=Environment.NewLine;
                }
                else
                {
                    if(i != notes.Length - 1)
                        lblNotes.Text += ": ";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentScreenMain studentScreenMain = new StudentScreenMain(_userName);
            studentScreenMain.ShowDialog();
        }
    }
}

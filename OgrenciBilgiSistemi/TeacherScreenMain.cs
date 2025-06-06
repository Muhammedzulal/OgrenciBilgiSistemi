using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class TeacherScreenMain : Form
    {
        public TeacherScreenMain()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciKayit ogrenciKayit = new OgrenciKayit();
            ogrenciKayit.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginForm = new LoginScreen(true);
            loginForm.ShowDialog();
        }

        private void btnNotGiris_Click(object sender, EventArgs e)
        {
            NotGiris notGiris = new NotGiris();
            this.Hide();
            notGiris.ShowDialog();
        }
    }
}

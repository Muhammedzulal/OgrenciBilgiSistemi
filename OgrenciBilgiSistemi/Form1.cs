using OgrenciBilgiSistemi.Ders;
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

namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tam ekran yapmayı devre dışı bırakmak için
            this.MaximizeBox = false;
        }
        StudentDal _studentDal = new StudentDal();
        SubjectDal _subjectDal = new SubjectDal();
        private void Form1_Load(object sender, EventArgs e)
        {
           _studentDal.Login("1", "1234");// Test amaçlı giriş yapılıyor
            //Çünkü ilk kez sorgu yapıldığında 2sn fln bekletiyor
            //bende ilk açılırken aradan çıkardım giriş yapılırken uğraştırmıyor
        }
       

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoginScreen studentScreen = new LoginScreen(false);
            studentScreen.Show();
            this.Hide();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            LoginScreen authorScreen= new LoginScreen(true);
            authorScreen.Show();
            this.Hide();
        }

        
    }
}

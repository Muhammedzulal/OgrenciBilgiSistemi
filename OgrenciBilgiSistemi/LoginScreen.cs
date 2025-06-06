using OgrenciBilgiSistemi.Ogrenci;
using OgrenciBilgiSistemi.Ogretmen;
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
    public partial class LoginScreen : Form
    {
        bool isTeacher; // Öğretmen mi öğrenci mi olduğunu tutan değişken
        public LoginScreen(bool isTeacher)
        {
            this.MaximizeBox = false;
            this.isTeacher = isTeacher; // Form oluşturulurken gelen değeri al
            InitializeComponent();
        }
        StudentDal _studentDal = new StudentDal();
        TeacherDal _teacherDal = new TeacherDal();

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnBack; // Form yüklendiğinde IdTxtBox odaklansın
            //IdTxtBox.Text = "Kullanıcı adınızı girin";
            //IdTxtBox.ForeColor = Color.Gray;
            //passwordTxtBox.UseSystemPasswordChar = false; // Şifre kutusu başlangıçta normal metin olarak görünsün
            //passwordTxtBox.Text = "Şifrenizi girin";
            //passwordTxtBox.ForeColor = Color.Gray;
        }

        private void IdTxtBox_Enter(object sender, EventArgs e)
        {
            if (IdTxtBox.Text == "Kullanıcı adınızı girin")
            {
                IdTxtBox.Text = "";
                IdTxtBox.ForeColor = Color.Black;
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if(passwordTxtBox.Text == "Şifrenizi girin")
            {
                passwordTxtBox.Text = "";
                passwordTxtBox.ForeColor = Color.Black;
                passwordTxtBox.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String UserName = IdTxtBox.Text.Trim();
            String Password = passwordTxtBox.Text.Trim();
            if (!isTeacher)
            {
                // Öğrenci girişi için
                bool result = _studentDal.Login(UserName, Password);
                if (result)
                {
                    this.Hide();
                    StudentScreenMain studentScreenMain = new StudentScreenMain(UserName);
                    studentScreenMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            else
            {
                // Öğretmen girişi için
                bool result = _teacherDal.Login(UserName, Password);
                if (result)
                {
                    this.Hide();
                    TeacherScreenMain teacherScreenMain = new TeacherScreenMain();
                    teacherScreenMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
        }
        //Form1 e geri dönme işlemi
        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close(); // Form1 kapatıldığında bu formu da kapat

        }
    }
}

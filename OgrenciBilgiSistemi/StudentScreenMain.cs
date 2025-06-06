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
using OgrenciBilgiSistemi.Ders;



namespace OgrenciBilgiSistemi
{
    public partial class StudentScreenMain : Form
    {
        private Student _student;   
        private string _studentName;
        private string _userName;
        Note _note = new Note();
        //Dictionary<Student, List<Subject>> _studentClasses;
        StudentDal _studenDal=new StudentDal();
        List<Dersler> _dersler = new List<Dersler>();
        public StudentScreenMain(string userName)
        {
            this.MaximizeBox = false;
            _student = _studenDal.GetByUserName(userName);
            InitializeComponent();
            //_studentClasses = new Dictionary<Student, List<Subject>>();
           // _studentClasses.Add(_studenDal.GetByUserName(userName), new List<Subject>());
            _userName = userName;
            _studentName= _studenDal.GetAll().FirstOrDefault(s => s.UserName == userName).Name+
               " "+ _studenDal.GetAll().FirstOrDefault(s => s.UserName == userName).Surname;
        }

        private void StudentScreenMain_Load(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini yükle
           studentPropsLbl.Text = $"Öğrenci Adı: {_studentName}\nNumara: {_userName}";
           double ortalama= _note.GetNote(_student.UserName);
            string ortalamaStr = ortalama.ToString("0.00"); // İki ondalık basamakla göster
            studentNoteLbl.Text = $"AGNO: {ortalamaStr}";
        }

        private void subjectRegisterBtn_Click(object sender, EventArgs e)
        {
            DersKayit dersKayit = new DersKayit(_student,_dersler);
            this.Hide();
            dersKayit.ShowDialog();
            
        }

        private void transcriptBtn_Click(object sender, EventArgs e)
        {
           if (_note.isExist(_student.UserName))
            {
                TranscriptScreen transcriptScreen = new TranscriptScreen(_student.UserName);
                this.Hide();
                transcriptScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Henüz ders kaydı yapılmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen(false);
            loginScreen.ShowDialog();
        }
    }
}

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
    public partial class OgrenciKayit : Form
    {
        StudentDal _studentDal=new StudentDal();
        Note _note =new Note();
        public OgrenciKayit()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }
        public void LoadStudents()
        {
            dgwStudents.DataSource = _studentDal.GetAll();
            dgwStudents.Columns["Id"].Visible = false;
            dgwStudents.RowHeadersVisible = false;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPhoneNo.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNo.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            try
            {
                Student newRegister = new Student
                {
                    Name = txtBoxName.Text,
                    Surname = txtBoxSurname.Text,
                    Email = txtBoxEmail.Text,
                    DateOfBirth = DateTime.Parse(txtBoxBirthDate.Text),
                    PhoneNumber = txtBoxPhoneNo.Text,
                    UserName = txtBoxNo.Text,
                    Password = txtBoxPassword.Text
                };
                _studentDal.Add(newRegister);
            }
            catch (FormatException)
            {
                MessageBox.Show("Doğum tarihi formatı geçersiz. Lütfen 'gg.aa.yyyy' formatında girin.");
                return;
            }
            LoadStudents();
            txtBoxName.Clear();
            txtBoxSurname.Clear();
            txtBoxEmail.Clear();
            txtBoxBirthDate.Clear();
            txtBoxPhoneNo.Clear();
            txtBoxNo.Clear();
            txtBoxPassword.Clear();
            MessageBox.Show("Öğrenci kaydı başarılı.");
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
           LoadStudents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherScreenMain teacherScreenMain = new TeacherScreenMain();
            teacherScreenMain.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = _studentDal.GetByUserName(txtBoxDeleteNo.Text);
            if (student != null)
            {
                _studentDal.Delete(student);
                LoadStudents();
                if(_note.isExist(student.UserName))
                {
                    _note.DeleteNote(student.UserName);
                }
                MessageBox.Show("Öğrenci silindi.");
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                txtBoxDeleteNo.Text = string.Empty;
            }
        }

      

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = dgwStudents.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtBoxDeleteNo.Text = userName;
        }
    }
}

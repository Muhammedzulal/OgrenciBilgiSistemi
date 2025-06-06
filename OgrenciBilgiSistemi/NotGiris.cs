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
    public partial class NotGiris : Form
    {
        Note _note =new Note();
        public NotGiris()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherScreenMain teacherScreenMain = new TeacherScreenMain();
            teacherScreenMain.ShowDialog();
        }

        private void NotGiris_Load(object sender, EventArgs e)
        {
           txtBoxNo.ForeColor=Color.Gray;
           txtBoxNo.Text = "Öğrenci No Giriniz";
        }

        private void txtBoxNo_Enter(object sender, EventArgs e)
        {
            txtBoxNo.ForeColor = Color.Black;
            if (txtBoxNo.Text == "Öğrenci No Giriniz")
            {
                txtBoxNo.Text = "";
            }
        }
        private void BilgiEkrani()
        {
            lblInfo.Text = "Öğrenci No: " + txtBoxNo.Text + Environment.NewLine+Environment.NewLine;
            string[] dersler = _note.GetAllNotes(txtBoxNo.Text);
            if (dersler == null || dersler.Length == 0)
            {
                MessageBox.Show("Öğrenci bulunamadı veya notları yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 1; i < dersler.Length; i++)
            {
                lblInfo.Text += dersler[i];
                
                if(i%2==0)
                {
                    lblInfo.Text += Environment.NewLine;
                }
                else
                {
                    if (i + 1 != dersler.Length)
                    {
                        lblInfo.Text += ": ";
                    }
                }
            }
        }
        private void ClearTextBox()
        {
           textBox1.Visible = false;
           textBox2.Visible = false;
           textBox3.Visible = false;
           textBox4.Visible = false;
           textBox5.Visible = false;
           lbl1.Visible = false;
           lbl2.Visible = false;
           lbl3.Visible = false;
           lbl4.Visible = false;
           lbl5.Visible = false;

        }
        private void ImgeGetir(string [] dersler,int length)
        {
            object[] items = new object[5];
            items[0] = textBox1;
            items[1] = textBox2;
            items[2] = textBox3;
            items[3] = textBox4;
            items[4] = textBox5;
            object[] items2 = new object[5];
            items2[0] = lbl1;
            items2[1] = lbl2;
            items2[2] = lbl3;
            items2[3] = lbl4;
            items2[4] = lbl5;
            int index = 1;
            for (int i = 0; i < length; i++)
            {
                object item = items[i];
                object item2 = items2[i];
                TextBox textBox = item as TextBox;
                textBox.Visible = true;
                Label label = item2 as Label;
                label.Visible = true;
                label.Text = dersler[index];
                index += 2;
            }
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            ClearTextBox();//İmgeleri temizle
            string no = txtBoxNo.Text;
            string[] dersler = _note.GetAllNotes(no);
            if (dersler == null || dersler.Length == 0)
            {
                MessageBox.Show("Öğrenci bulunamadı veya notları yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            int uzunluk = (dersler.Length - 1) / 2;
            ImgeGetir(dersler, uzunluk);//İmgeleri getir
            BilgiEkrani();//Bilgi ekranını doldur
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            string no = txtBoxNo.Text;
            StudentDal _studentDal = new StudentDal();
            if (string.IsNullOrEmpty(txtBoxNo.Text) || txtBoxNo.Text == "Öğrenci No Giriniz"||!_studentDal.isExist(no))
            {
                lblInfo.Text = "";
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool b1 = false, b2 = false, b3 = false, b4 = false, b5 = false;
            if (textBox1.Visible){ b1 = textBox1.Text == string.Empty;}
            if (textBox2.Visible){ b2 = textBox2.Text == string.Empty;}
            if (textBox3.Visible){ b3 = textBox3.Text == string.Empty;}
            if (textBox4.Visible){ b4 = textBox4.Text == string.Empty;}
            if (textBox5.Visible){ b5 = textBox5.Text == string.Empty;}
            
            if (b1 || b2 || b3 || b4 || b5)
            {
                lblInfo.Text = "";
                MessageBox.Show("Lütfen tüm ders notlarını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> notlar = new List<int>();
            try
            {
                if (textBox1.Visible) { notlar.Add(Convert.ToInt32(textBox1.Text));}
                if (textBox2.Visible) { notlar.Add(Convert.ToInt32(textBox2.Text));}
                if (textBox3.Visible) { notlar.Add(Convert.ToInt32(textBox3.Text));}
                if (textBox4.Visible) { notlar.Add(Convert.ToInt32(textBox4.Text));}
                if (textBox5.Visible) { notlar.Add(Convert.ToInt32(textBox5.Text));}

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli notlar giriniz. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _note.UpdateNote(no,notlar);
                lblInfo.Text = "Notlar başarıyla eklendi.";
                ClearTextBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli notlar giriniz. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BilgiEkrani();//Bilgi ekranını doldur
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciBilgiSistemi.Ders;
using OgrenciBilgiSistemi.Ogrenci;

namespace OgrenciBilgiSistemi
{
    public partial class DersKayit : Form
    {
        Student _student;
        SubjectDal _subjectDal = new SubjectDal();
        Dictionary<Student,List<Dersler>> _studentSubjects = new Dictionary<Student, List<Dersler>>();
        List<int> secilenler = new List<int>();
        List<string> strings = new List<string>();
        List<Dersler> _dersler;
        Note _note = new Note();
       

        public DersKayit(Student student,List<Dersler> dersler)
        {
            this.MaximizeBox = false;
            _student = student;
            _dersler = dersler;
            InitializeComponent();
            dgwDersler.DataSource = _subjectDal.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            int secilenDers=dgwDersler.CurrentRow.Index;
            if (!secilenler.Contains(dgwDersler.CurrentRow.Index))
            {
                
                Subject subject = (Subject)dgwDersler.CurrentRow.DataBoundItem;
                String txt = subject.Name + " - " + subject.Credit + " Kredi | " + (subject.Status == 1 ? "Z" : "S");
                lblDersler.Text += txt + Environment.NewLine;
                strings.Add(subject.Name);
            }
            else {                
                MessageBox.Show("Bu dersi zaten seçtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            secilenler.Add(secilenDers);
        }
        private void btnKesinlestir_Click(object sender, EventArgs e)
        {
            if (secilenler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Zorunlu derslerin seçilmesi için kontrol eklenebilir.
            for (int i = 0; i < 6; i++)
            {
               if (!strings.Contains("Algoritma"))
               {
                MessageBox.Show("Algoritma dersi zorunludur. Lütfen seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               }
               if (!strings.Contains("Matematik"))
               {
                   MessageBox.Show("Matematik dersi zorunludur. Lütfen seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
                }
               if (!strings.Contains("Bot"))
                {
                    MessageBox.Show("Bilgisayar Organizasyonu ve Mimarisi dersi zorunludur. Lütfen seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i] == "Algoritma")
                {
                    _dersler.Add(new Algoritma());
                }
                else if (strings[i] == "Matematik")
                {
                    _dersler.Add(new Matematik());
                }
                else if (strings[i] == "Goruntu")
                {
                    _dersler.Add(new Goruntu());
                }
                else if (strings[i] == "Proje")
                {
                    _dersler.Add(new Proje());
                }
                else if (strings[i] == "Bot")
                {
                    _dersler.Add(new Bot());
                }
            }     
            _studentSubjects.Add(_student, _dersler);
            string text = "";
            text+=Environment.NewLine;
            for (int i = 0; i < _dersler.Count; i++)
            {
                text += _dersler[i].GetType().Name + Environment.NewLine;
            }
            MessageBox.Show(_student.Name+" Öğrencisine "+text+" dersleri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnKesinlestir.Enabled = false;
            btnEkle.Enabled = false;
            btnDersSil.Enabled = false;
            //Dosyaya yazma işlemi burada yapılabilir.
            string metin = "";
            metin += _student.UserName + ",";
            for (int i = 0; i < strings.Count; i++)
            {
                metin += strings[i] + ",0,";
            }
            _note.SaveNote(metin);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentScreenMain studentScreenMain = new StudentScreenMain(_student.UserName);
            studentScreenMain.ShowDialog();
        }

        

        private void DersKayit_Shown(object sender, EventArgs e)
        {
            if (_note.isExist(_student.UserName))
            {
                btnEkle.Enabled = false;
                btnKesinlestir.Enabled = false;
                dgwDersler.Enabled = false;
                btnDersSil.Enabled = false;
                MessageBox.Show("Ders kaydınız zaten yapılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DersKayit_Load(object sender, EventArgs e)
        {
            lblDersler.Text = string.Empty;
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            lblDersler.Text = string.Empty;
            secilenler.Clear();
        }
    }
}


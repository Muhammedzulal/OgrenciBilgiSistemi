using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OgrenciBilgiSistemi.Ogrenci
{
    public class Note
    {
        string filePath = "C:\\Users\\muham\\OneDrive\\Masaüstü\\Dersler.txt";
        public void SaveNote(string note)//Dersleri ve notları kaydetmek için
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filePath, true))
                {
                    file.WriteLine(note);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving the note: " + ex.Message);
            }
        }
        public double GetNote(string UserName)
        {
            int satirBasi = Convert.ToInt32(UserName);
            //Dosya yoksa
            
            string[] satirlar = File.ReadAllLines(filePath);

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');

                if (parcalar.Length > 1 && Convert.ToInt32(parcalar[0]) == satirBasi)
                {
                    double toplam = 0;
                    //[0] ID,  [1] ders adı, [2] not,
                    for (int i = 2; i < parcalar.Length; i += 2)
                    {
                        toplam += Convert.ToInt32(parcalar[i]);
                    }

                    return (toplam / ((parcalar.Length - 1) / 2));
                }
            }

            return 0; //Kaçış
        }//Ortalama

        public string[] GetAllNotes(string username) //Tüm notları almak için
        {
            int satirBasi = 0;
            try { satirBasi = Convert.ToInt32(username); }catch (FormatException)
            {
                MessageBox.Show("Geçersiz format. Lütfen geçerli bir öğrenci numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[0]; // Return an empty array if the format is invalid
            }
            string[] satirlar = File.ReadAllLines(filePath);
            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');

                if (parcalar.Length > 1 && Convert.ToInt32(parcalar[0]) == satirBasi)
                {


                    return parcalar;
                }
            }
            return null;
        }
        public bool isExist(string username) //Notların varlığını kontrol etmek için
        {
            if(string.IsNullOrEmpty(username) || !int.TryParse(username, out _))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if the input is invalid
            }
            int satirBasi = Convert.ToInt32(username);
            string[] satirlar = File.ReadAllLines(filePath);
            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');
                if (parcalar.Length > 1 && Convert.ToInt32(parcalar[0]) == satirBasi)
                {
                    return true;
                }
            }
            return false;
        }
        public void DeleteNote(string username) //Notları silmek için
        {
            int satirBasi = Convert.ToInt32(username);
            string[] satirlar = File.ReadAllLines(filePath);
            List<string> yeniSatirlar = new List<string>();
            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');
                if (parcalar.Length > 1 && Convert.ToInt32(parcalar[0]) != satirBasi)
                {
                    yeniSatirlar.Add(satir);
                }
            }
            File.WriteAllLines(filePath, yeniSatirlar);
        }

        public void UpdateNote(string username, List<int> list) //Notları güncellemek için
        {
           int satirbasi= Convert.ToInt32(username);
           string[] satirlar = File.ReadAllLines(filePath);
            List<string> yeniSatirlar = new List<string>();
            for (int i = 0; i < satirlar.Length; i++)
            {
                string satir = satirlar[i];
                string[] parcalar=satir.Split(',');
                if(parcalar.Length > 1 && Convert.ToInt32(parcalar[0]) != satirbasi)
                {
                    yeniSatirlar.Add(satir);
                }
                else 
                { 
                    int dersSayisi = (parcalar.Length - 1) / 2; // Not sayısını hesapla
                    for (int j = 0; j < dersSayisi; j++)
                    {
                       parcalar[2 + j * 2] = list[j].ToString(); // Notları güncelle
                    }
                    string yeniSatir = string.Join(",", parcalar);
                    yeniSatirlar.Add(yeniSatir); // Güncellenmiş satırı ekle
                }
            }
            try
            {
                File.WriteAllLines(filePath, yeniSatirlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notlar güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using OgrenciBilgiSistemi.Ogrenci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Ogretmen
{
    public class TeacherDal
    {
        public bool Login(string username, string password)
        {
            using (TeacherContext context = new TeacherContext())
            {
                return context.Teachers.Any(s =>
                    s.UserName == username &&
                    s.Password == password);
            }
        }

        public void NotGiris()
        {

        }
        public void OgrenciKayit()
        {

        }
    }
}

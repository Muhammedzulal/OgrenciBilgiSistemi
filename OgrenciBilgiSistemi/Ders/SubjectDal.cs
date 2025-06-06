using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciBilgiSistemi.Ogrenci; // Assuming StudentContext is in the Ogrenci namespace

namespace OgrenciBilgiSistemi.Ders
{
    public class SubjectDal
    {
        public List<Subject> GetAll()
        {
            using (SubjectContext context = new SubjectContext())
            {
                return context.Subjects.ToList();
            }
        }
    }
}

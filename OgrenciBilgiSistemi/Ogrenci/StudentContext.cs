using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciBilgiSistemi.Ders; // Assuming Subject is in the Ders namespace

namespace OgrenciBilgiSistemi.Ogrenci
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}

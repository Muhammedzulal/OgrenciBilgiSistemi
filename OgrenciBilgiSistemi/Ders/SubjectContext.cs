using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Ders
{
    public class SubjectContext:DbContext
    {
       public DbSet<Subject> Subjects { get; set; }
    }
}

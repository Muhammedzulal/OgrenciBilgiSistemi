using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Ogretmen
{
    public class TeacherContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
    }
}

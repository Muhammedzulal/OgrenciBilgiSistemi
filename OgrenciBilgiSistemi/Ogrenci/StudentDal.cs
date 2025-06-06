using OgrenciBilgiSistemi.Ders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Ogrenci
{
    public class StudentDal
    {
        public List<Student> GetAll()
        {
            using (StudentContext context = new StudentContext())
            {
                return context.Students.ToList();
            }
        }
       
        public bool Login(string username, string password)
        {
            using (StudentContext context = new StudentContext())
            {
                return context.Students.Any(s =>
                    s.UserName== username &&
                    s.Password == password);
            }
        }
        
        public Student GetByUserName(string userName)
        {
            using (StudentContext context = new StudentContext())
            {
                return context.Students.FirstOrDefault(s => s.UserName == userName);
            }
        }
        public void Add(Student student)
        {
            using (StudentContext context = new StudentContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        public void Delete(Student student)
        {
            using (StudentContext context = new StudentContext())
            {
                var entity = context.Entry(student);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public bool isExist(string username)
        {
            using (StudentContext context = new StudentContext())
            {
                return context.Students.Any(s => s.UserName == username);
            }
        }
    }
}

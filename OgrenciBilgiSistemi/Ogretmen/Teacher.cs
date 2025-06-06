using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Ogretmen
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Teacher() { }
        public Teacher(int id,string name, string surname, string description, string email,string userName,string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            UserName = userName;
            Password = password;
        }
    }
}

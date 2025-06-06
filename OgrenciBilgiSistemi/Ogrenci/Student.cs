using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciBilgiSistemi.Ders;

namespace OgrenciBilgiSistemi.Ogrenci
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Student()
        {
            
        }
        public Student(int id, string name, string surname, string email, DateTime dateOfBirth, string phoneNumber, string userName, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            UserName = userName;
            Password = password;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} ({Email})";
        }
    }
}

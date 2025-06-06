using System;

namespace OgrenciBilgiSistemi.Ders
{
    public abstract class Dersler
    {
        protected string DersAdi;
        protected int Kredi;
        protected int Not;

        public string GetDersAdi()
        {
            return DersAdi;
        }

        public int GetKredi()
        {
            return Kredi;
        }

        public abstract void DersBilgisi();
    }

    public abstract class Elective : Dersler
    {
        public void IsElective()
        {
            Console.WriteLine("Bu ders seçmelidir.");
        }

        public void OnerilenSeviye()
        {
            Console.WriteLine("Bu ders genellikle 3. veya 4. sınıflar için önerilir.");
        }
    }

    public abstract class Compulsory : Dersler
    {
        public void IsCompulsory()
        {
            Console.WriteLine("Bu ders zorunludur.");
        }

        public void KatilmakZorunluMu()
        {
            Console.WriteLine("Bu derse devamsızlık hakkı sınırlıdır.");
        }
    }

    public class Algoritma : Compulsory
    {
        public Algoritma()
        {
            DersAdi = "Algoritma ve Programlama";
            Kredi = 4;
            Not = 0;
        }

        public override void DersBilgisi()
        {
            Console.WriteLine("Programlama temellerini öğretir.");
        }
    }

    public class Matematik : Compulsory
    {
        public Matematik()
        {
            DersAdi = "Matematik";
            Kredi = 3;
            Not = 0;
        }

        public override void DersBilgisi()
        {
            Console.WriteLine("Limit, türev, integral gibi konuları içerir.");
        }
    }

    public class Bot : Compulsory
    {
        public Bot()
        {
            DersAdi = "Bilgisayar Organizasyonu ve Mimarisi";
            Kredi = 3;
            Not = 0;
        }

        public override void DersBilgisi()
        {
            Console.WriteLine("Bir bilgisayarın donanımsal yapısını anlatır.");
        }
    }

    public class Goruntu : Elective
    {
        public Goruntu()
        {
            DersAdi = "Görüntü İşleme";
            Kredi = 3;
            Not = 0;
        }

        public override void DersBilgisi()
        {
            Console.WriteLine("Pikseller, filtreler ve görsel analiz konularını kapsar.");
        }
    }

    public class Proje : Elective
    {
        public Proje()
        {
            DersAdi = "Proje Yönetimi";
            Kredi = 2;
            Not = 0;
        }

        public override void DersBilgisi()
        {
            Console.WriteLine("Projelerin nasıl planlanıp yürütüleceğini öğretir.");
        }
    }
}

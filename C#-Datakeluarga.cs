using System;

public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     
     familydata ayahku = new familydata("Atim slamet Hariyadi",48,+6282345678908);
    familydata ibuku = new familydata("sunarsih",48,+6282345678908);
    familydata aku = new familydata("M Amir Pasya",17,+6283347678998);
     Console.WriteLine("data ayah:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("data ibu:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("data anak:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
     
        

    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
       
        
        
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Travelling");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("berkebun");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bermain game");
        }
    }
    

}

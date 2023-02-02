namespace App 
{

    class Rumus 
    {

        public int hasil;
        public string? nama =null;

        public static void tampil(){
            Console.WriteLine("belajar static");
        }

        public int set(int hasil,string nama){
            this.nama=nama;
            return this.hasil = hasil;

        }

        public void get(){
            Console.WriteLine(this.hasil);
        }
    }

}
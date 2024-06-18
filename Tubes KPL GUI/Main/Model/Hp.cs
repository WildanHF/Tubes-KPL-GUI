namespace Main.Model
{
    public class Hp
    {
        public string NamaBarang { get; set; }
        public int KodeBarang { get; set; }
        public int JumlahBarang { get; set; }
        public int HargaBarang { get; set; }

        public Hp(string namaBarang, int kodeBarang, int jumlahBarang, int hargaBarang)
        {
            NamaBarang = namaBarang;
            KodeBarang = kodeBarang;
            JumlahBarang = jumlahBarang;
            HargaBarang = hargaBarang;
        }

        internal static void Add(Hp Hp)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAt(int id)
        {
            throw new NotImplementedException();
        }
    }
}


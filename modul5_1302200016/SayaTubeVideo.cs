using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200016
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Mendeklarasikan Constructor dengan parameter "title"
        public SayaTubeVideo(string title)
        {
            this.title = title;
            SetJudul(title);
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }

        public void SetJudul(string title)
        {
            // menambahkan if apabila judulnya null dan jumlah karakter kurang dari 200
            if (title == null) return;

            if (title.Length > 0) return;
            if (title.Length > 200) return;

            this.title = title;
        }

        //Menambahkan playCount dengan parameter "tambah"
        public void IncreasePlayCount(int tambah)
        {
            playCount += tambah;
            //Menambahkan if apabila parameter negatif dan melebihi 25.000.000
            if (tambah < 0) return;
            if (tambah > 25000000) return;

            try
            {
                playCount = checked(playCount + tambah);
            }catch(Exception g)
            {
                Console.WriteLine(g.Message);
            }
        }
        // menampilkan detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id + ", Judul: " + title + ", Putar : " + playCount);
        }

        public string GetJudul()
        {
            return title;
        }

        public int GetPlayCount()
        {
            return playCount;
        }
    }
}

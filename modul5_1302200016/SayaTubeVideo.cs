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
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }

        //Menambahkan playCount dengan parameter "tambah"
        public void IncreasePlayCount(int tambah)
        {
            this.playCount += tambah;
        }
        // menambahkan informasi video (ID, Judul, Putar)
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

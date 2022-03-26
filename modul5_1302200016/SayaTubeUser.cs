using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200016
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            SetUsername(username);
            this.Username = username;
            this.id = new Random().Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void SetUsername(string username)
        {
            // Menambahkan if apabila parameternya null dan panjang karakter lebih dari 100
            if (username == null) return;
            if (username.Length == 0) return;
            if (username.Length > 100) return;

            this.Username = username;
        }
        public int GetTotalVideoPlayCount()
        {
            int count = 0;

            // Melakukan looping
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                try
                {
                    count = checked(count + video.GetPlayCount());
                }catch (Exception g)
                {
                    Console.WriteLine(g.Message);
                    break;
                }
            }
            return count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            // menambahkan if apabila parameter video null
            if (video == null) return;
            
            if (video.GetPlayCount() > int.MaxValue)
            {
                this.uploadedVideos.Add(video);
            }
        }

        public void PrintAllVideoPlayCount()
        {
            int nomor = 1;
            Console.WriteLine("User: " + this.Username);

            //melakukan Looping 
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
               // menambahakan if apabila nomor lebih dari 8
                if (nomor > 8) break;

                // menampilkan ketika nomor kurang dari 8
                Console.WriteLine("Video " + nomor + ": " + video.GetJudul());
                nomor++;
            }
        }

    }
}

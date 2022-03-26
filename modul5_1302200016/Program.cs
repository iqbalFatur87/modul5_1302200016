using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Muhamad Iqbal F");

            SayaTubeVideo no1 = new SayaTubeVideo("Review Film - The Conjuring 2 oleh Muhamad Iqbal F");
            SayaTubeVideo no2 = new SayaTubeVideo("Review Film - Pengabdi Setan oleh Muhamad Iqbal F");
            SayaTubeVideo no3 = new SayaTubeVideo("Review Film - Perempuan Tanah Jahannam oleh Muhamad Iqbal F");
            SayaTubeVideo no4 = new SayaTubeVideo("Review Film - Insidious Chapter 4 oleh Muhamad Iqbal F");
            SayaTubeVideo no5 = new SayaTubeVideo("Review Film - Texas Chainsaw Massacre oleh Muhamad Iqbal F");
            SayaTubeVideo no6 = new SayaTubeVideo("Review Film - Friday The 13th oleh Muhamad Iqbal F");
            SayaTubeVideo no7 = new SayaTubeVideo("Review Film - Halloween oleh Muhamad Iqbal F");
            SayaTubeVideo no8 = new SayaTubeVideo("Review Film - Alien (1979) oleh Muhamad Iqbal F");
            SayaTubeVideo no9 = new SayaTubeVideo("Review Film - The Lighthouse oleh Muhamad Iqbal F");
            SayaTubeVideo no10 = new SayaTubeVideo("Review Film - The Exorcist oleh Muhamad Iqbal F");

            user.AddVideo(no1);
            user.AddVideo(no2);
            user.AddVideo(no3);
            user.AddVideo(no4);
            user.AddVideo(no5);
            user.AddVideo(no6);
            user.AddVideo(no7);
            user.AddVideo(no8);
            user.AddVideo(no9);
            user.AddVideo(no10);

            user.PrintAllVideoPlayCount();
        }
    }
}

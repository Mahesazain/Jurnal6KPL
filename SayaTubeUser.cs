using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302220105
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String username;

        public SayaTubeUser(String username)
        {
            this.id = new Random().Next(10000, 99999); 
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        
        public int getTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: "+this.username);
            for (int i=0; i<this.uploadedVideos.Count();i++)
            {
                SayaTubeVideo video = this.uploadedVideos[i];
                Console.WriteLine("Video "+(i+1)+" Judul: "+video.getTitle());
            }
            Console.WriteLine("Total Play Count: "+getTotalVideoPlayCount());
        }
    }
}

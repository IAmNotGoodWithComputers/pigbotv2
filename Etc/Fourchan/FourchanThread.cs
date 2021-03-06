using System.Collections.Generic;

namespace PigBot.Etc
{
    public class Post
    {
        public int No { get; set; }
        public string Now { get; set; }
        public string Name { get; set; }
        public string Sub { get; set; }
        public string Com { get; set; }
        public string Filename { get; set; }
        public string Ext { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int TnW { get; set; }
        public int TnH { get; set; }
        public ulong Tim { get; set; }
        public int Time { get; set; }
        public string Md5 { get; set; }
        public int Fsize { get; set; }
        public int Resto { get; set; }
        public int Bumplimit { get; set; }
        public int Imagelimit { get; set; }
        public string SemanticUrl { get; set; }
        public int Replies { get; set; }
        public int Images { get; set; }
        public int UniqueIps { get; set; }
        public int TailSize { get; set; }
    }

    public class Thread
    {
        public List<Post> Posts { get; set; }
    }
}
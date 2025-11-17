using System;

namespace Documents_Lukashevich.Model
{
    public class Document
    {
        public int id { get; set; }
        public string src { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public int id_document { get; set; }
        public DateTime date { get; set; }
        public int status { get; set; }
        public string vector { get; set; }
    }
}
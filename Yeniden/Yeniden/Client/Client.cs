using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yeniden.Repositories;


namespace Yeniden.Models
{
    public class Client
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Yazar { get; set; }
        public string Kategori { get; set; }
        public string Yayıncı { get; set; }
        public string ISBN { get; set; }
        public bool Available { get; set; }
    }
}

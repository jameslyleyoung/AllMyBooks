using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllMyBooks.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int MyProperty { get; set; }
    }
}

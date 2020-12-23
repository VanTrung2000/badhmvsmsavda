using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Domain.Response
{
    public class GetBooks
    {
        public int BookID { set; get; }
        public string BookName { set; get; }
        public string Author { set; get; }
        public string ShortContents { set; get; }
        public int YearReleased { set; get; }
        public int Amount { get; set; }
        public string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOop.BL
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> Chapters = new List<string>();
        public int bookmark;
        public int price;
        public Book(string author,int pages,List<String> Chapters,int bookmark,int price)
        {
            this.author = author;
            this.pages = pages;
            this.Chapters = Chapters;
            this.bookmark = bookmark;
            this.price = price;
        }
        public string getChapter(int num)
        {
            return Chapters[num];
        }
        public int getbookmark()
        {
            return bookmark;
        }
        public void setbookmark(int page)
        {
            bookmark = page;
        }
        public int getprice()
        {
            return price;
        }
        public void setprice(int price)
        {
            this.price = price;
        }
    }
}

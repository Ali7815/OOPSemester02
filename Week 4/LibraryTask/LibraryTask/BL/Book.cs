using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask.BL
{
    class Book
    {
        public string author;
        public string title;
        public List<string> chapters = new List<string>();
        public int pages;
        public int price;
        public int bookmark;
        public Book(string author, string title, List<string> chapters, int pages, int price, int bookmark)
        {
            this.author = author;
            this.title = title;
        }
        public string getchapter(int chp)
        {
            return chapters[chp];
        }
        public int getbookmark()
        {
            return bookmark;
        }
        public void setbookmark(int page)
        {
            bookmark = page;
            
        }
        public int getbookprice()
        {
            return price;
        }
        public void setbookprice(int newprice)
        {
            price = newprice;
        }
    }
    
}

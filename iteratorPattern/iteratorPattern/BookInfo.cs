using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteratorPattern
{
    class BookInfo
    {
        Book[] book = new Book[15];
        public Book[] Books()
        {
            for (int i = 0; i < 15; i++)
            {

                book[i] = new Book();
            }
            return book;
        }
     
    }
}

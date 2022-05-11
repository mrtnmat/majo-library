using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class Library
    {
        HashSet<BookData> _catalog;
        public Library()
        {
            _catalog = new HashSet<BookData>();
        }

        public bool AddNewBook(BookData b)
        {
            return _catalog.Add(b);
        }

        public bool AddBookCopy(BookData b)
        {
            if (_catalog.TryGetValue(b, out BookData updatedBook))
            {
                _catalog.Remove(b);
                updatedBook.AddCopy();
                return _catalog.Add(updatedBook);
            }
            return false;
        }
    }
}

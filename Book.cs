using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class Book
    {
        string _title;
        string _author;
        public Book(string title, string author) => (_title, _author) = (title, author);

        public string Title => _title;
        public string Author => _author;
        public override bool Equals(object obj)
        {
            return obj is Book && Equals((Book)obj);
        }
        public bool Equals(Book b)
        {
            return _title == b.Title && _author == b.Author;
        }

        public override int GetHashCode()
        {
            return (_title + _author).GetHashCode();
        }
    }
}

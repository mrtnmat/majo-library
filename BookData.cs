using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class BookData
    {
        string _title;
        string _author;
        int _totalCopies;
        int _copiesLent;
        public BookData(string title, string author) => (_title, _author, _totalCopies, _copiesLent) = (title, author, 1, 0);

        public string Title => _title;
        public string Author => _author;
        public int Copies => _totalCopies;

        public void AddCopy()
        {
            _totalCopies += 1;
        }
        public override bool Equals(object obj)
        {
            return obj is BookData && Equals((BookData)obj);
        }
        public bool Equals(BookData b)
        {
            return _title == b.Title && _author == b.Author;
        }

        public override int GetHashCode()
        {
            return (_title + _author).GetHashCode();
        }
    }
}

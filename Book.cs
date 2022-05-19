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
        int _totalCopies;
        int _copiesLent;
        public Book(string title, string author) => (_title, _author, _totalCopies, _copiesLent) = (title, author, 1, 0);

        public string Title => _title;
        public string Author => _author;
        public int Copies => _totalCopies;
        public int CopiesAvailable => _totalCopies - _copiesLent;

        public void AddCopy()
        {
            _totalCopies += 1;
        }
        public bool LendCopy()
        {
            if (CopiesAvailable > 0)
            {
                _copiesLent =+ 1;
                return true;
            }
            return false;
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

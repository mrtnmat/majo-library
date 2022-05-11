using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class BorrowRecord
    {
        User _user;
        BookData _book;

        public User Lendee => _user;
        public BookData BookLent => _book;

        public bool Equals(BorrowRecord p)
        {
            return p.Lendee == Lendee && p.BookLent == BookLent;
        }
    }
}

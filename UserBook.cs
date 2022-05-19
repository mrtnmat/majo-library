using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class UserBook
    {
        User _user;
        Book _book;

        public User Lendee => _user;
        public Book BookLent => _book;

        public bool Equals(UserBook p)
        {
            return p.Lendee == Lendee && p.BookLent == BookLent;
        }
    }
}

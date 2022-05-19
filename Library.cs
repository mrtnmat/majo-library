using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class Library
    {
        Dictionary<Book, Book> _catalog;
        Dictionary<User, User> _userDatabase;
        public Dictionary<Book, Book> Catalog => _catalog;

        public Library()
        {
            _catalog = new ();
            _userDatabase = new();
        }

        public void AddBook(Book b)
        {
            
            if (_catalog.ContainsKey(b))
            {
                _catalog[b] = _catalog[b].AddCopy();
            }
            else
            {
                _catalog[b] = b;
            }
        }

        public void AddUser(User u)
        {
            _userDatabase[u] = u;
        }

        public bool LendBook(Book b, User u)
        {
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class Library
    {
        HashSet<Book> _catalog;
        HashSet<User> _userDatabase;
        public List<Book> Catalog => _catalog.ToList();

        public Library()
        {
            _catalog = new HashSet<Book>();
        }

        public bool AddBook(Book b)
        {
            if (_catalog.TryGetValue(b, out Book updatedBook))
            {
                _catalog.Remove(b);
                updatedBook.AddCopy();
                return _catalog.Add(updatedBook);
            }
            else
            {
                return _catalog.Add(b);
            }
        }

        public void AddUser(User u)
        {
            _userDatabase.Add(u);
        }

        public bool LendBook(string title, string author, int id)
        {
            Book s = new(title, author);
            _catalog.TryGetValue(s, out Book catalogBook);
            if (_userDatabase.ContainsKey(id) && catalogBook.CopiesAvailable > 0)
            {
                catalogBook.LendCopy();
                return true;
            }
            return false;
        }
    }
}

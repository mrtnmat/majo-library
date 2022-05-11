﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class Library
    {
        HashSet<BookData> _catalog;
        Dictionary<int, User> _userDatabase;
        public Library()
        {
            _catalog = new HashSet<BookData>();
        }

        public bool AddBook(BookData b)
        {
            if (_catalog.TryGetValue(b, out BookData updatedBook))
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

        public void AddUser()
        {
            User u = new User();
            _userDatabase[u.Id] = u;
        }
    }
}

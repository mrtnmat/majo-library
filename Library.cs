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
        public Library()
        {
            _catalog = new HashSet<Book>();
        }
    }
}

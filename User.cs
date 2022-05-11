using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majo_library
{
    class User
    {
        static int _increment = 0;

        readonly int _id;

        public int Id => _id;

        public User()
        {
            _id = _increment;
            _increment++;
        }

        public override bool Equals(object obj)
        {
            return obj is User && this.Equals((User)obj);
        }

        public bool Equals(User u)
        {
            return _id == u.Id;
        }

        public override int GetHashCode()
        {
            return _id;
        }
    }
}

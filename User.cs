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
        string _name, _surname, _phoneNumber;

        public string Name => _name;
        public string Surname => _surname;
        public string PhoneNumber => _phoneNumber;

        public int Id => _id;

        public User()
        {
            _id = _increment;
            _increment++;
        }

        public bool Equals(User u)
        {
            return _name == u.Name && _surname == u.Surname && _phoneNumber == u.PhoneNumber;
        }

        public override int GetHashCode()
        {
            return (_name + _surname + _phoneNumber).GetHashCode();
        }
    }
}

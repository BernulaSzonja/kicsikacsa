using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kicsikacsa
{
    internal class Author
    {
        public Guid Guid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Author(Guid Guid, string lastName, string firstName)
        {
            if (lastName.Length < 3 || lastName.Length > 32)
                throw new ArgumentException("a vezeteknevnek 3 es 32 karakter kozottinek kell lennie");
            if (firstName.Length < 3 || firstName.Length > 32)
                throw new ArgumentException("a keresztnevnek 3 es 32 karakter kozottinek kell lennie");

            Guid = Guid.NewGuid();
            this.lastName = lastName;
            this.firstName = firstName;
        }


        public string getNev()
        {
            return $"{this.lastName} {this.firstName}";
        }
    }
}

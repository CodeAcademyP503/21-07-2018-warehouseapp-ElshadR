using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class User
    {
        private int Id { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                addId();
            }
        }
        public string Surname { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public decimal Total { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public Role Role { get; set; }

        private static int count = 1;
        public void addId()
        {
            Id = count;
            count++;
        }
        public int showId()
        {
            return Id;
        }

    }
}

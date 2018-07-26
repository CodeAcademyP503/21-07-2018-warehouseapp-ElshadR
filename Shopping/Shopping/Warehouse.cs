using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Warehouse
    {
        private int Id { get; set; }
        private string _name;
        public string Name {
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
        public string Adress { get; set; }
        public User[] users = new User[20];
        public Grade Grade { get; set; }


        private int count=1;
        public void addId()
        {
            Id = count;
            count++;
        }

    }
}

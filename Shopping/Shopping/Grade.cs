using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public percentOrManat perOrMan { get; set; }


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

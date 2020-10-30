using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___LoginForm
{
    public class Spolovi
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}

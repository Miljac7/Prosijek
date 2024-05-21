using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsekOcena
{
    internal class Prosek
    {
        string nazivPredmeta;
        int ocjena;

        

        public Prosek(string nazivPredmeta, int ocjena)
        {
            this.nazivPredmeta = nazivPredmeta;
            this.Ocjena = ocjena;
        }

        public Prosek()
        {

        }
        public string NazivPredmeta { get => nazivPredmeta; set => nazivPredmeta = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }
    }
}

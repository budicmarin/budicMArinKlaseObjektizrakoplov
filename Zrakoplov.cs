
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMArinKlaseObjektizrakoplov
{
    class Zrakoplov
    {
        private string naziv;
        private string snagaMotora;
        private string dosegLeta;
        public Zrakoplov()
        {
        }
        public string Naziv   // property
        {
            get { return naziv; }   // get method
            set { naziv = value; }  // set method
        }
        public string SnagaMotora
        {
            get { return snagaMotora; }
            set { snagaMotora = value; }

        }
        public string DosegLeta
        {
            get { return dosegLeta; }
            set { dosegLeta = value; }
        }
        public string ToString
        {
            get
            {
                string rec = "Naziv = " + Naziv +
                    "\nSnaga Motora = " + SnagaMotora +
                    "\nDoseg Leta = " + DosegLeta; ;
                return rec;
            }
        }
    }
}

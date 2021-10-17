using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitAraba
{
    class Tasit
    {


    }

    class Araba : Tasit
    {
        public string Marka, Model, Segment;

        public Araba(string marka, string model, string segment)
        {
            Marka = marka;
            Model = model;
            Segment = segment;
        }

        public int Yil;

        public Araba(int yil)
        {
            Yil = yil;
        }

        public Araba()
        {
        }
    }

}

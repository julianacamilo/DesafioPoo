using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPoo.Models
{
    public class Nokia : Smartphone

    {
        public Nokia(string Numero) : base(Numero) { }
       public Nokia(int Memoria) : base(Memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            throw new NotImplementedException();
        }

        
    }
}
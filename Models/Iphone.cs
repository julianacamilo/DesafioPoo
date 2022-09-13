using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPoo.Models
{
    public class Iphone : Smartphone
    {
        private string nomeApp;

        public Iphone(string Numero) : base(Numero) { }
       public Iphone(int Memoria) : base(Memoria) { }
     
        
        public override void InstalarAplicativo(string nomeApp)
        {
          // Console.WriteLine("Instalando aplicativo");
           // throw new NotImplementedException();
        }

        

    }


}
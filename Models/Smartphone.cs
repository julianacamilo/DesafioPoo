using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPoo.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        public string Modelo { get; set; }
        public Smartphone(string numero, string imei, int memoria, string modelo)
        {
            Numero = numero;
            Imei = imei;
            Memoria = memoria;
            Modelo = modelo;

            
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        protected Smartphone(int memoria)
        {
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
    }

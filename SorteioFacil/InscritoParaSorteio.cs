using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioFacil
{
    internal class InscritoParaSorteio 
    {
        public int Numero { get; set; }
        public String Nome { get; set; }

        public InscritoParaSorteio() { }

        public InscritoParaSorteio(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public override string ToString()
        {
            return "Numero: " + Numero + " - Nome:  " + Nome;
        }

       
    }
}

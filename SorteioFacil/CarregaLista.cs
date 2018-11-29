using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace SorteioFacil
{
    class CarregaLista
    {

        public List<InscritoParaSorteio> Carga()
        {


            List<InscritoParaSorteio> inscritos = new List<InscritoParaSorteio>
            {
                new InscritoParaSorteio(1, "Gabriel"),
                new InscritoParaSorteio(2, "Pedro"),
                new InscritoParaSorteio(3, "Murillo"),
                new InscritoParaSorteio(4, "Thomas"),
                new InscritoParaSorteio(5, "Joseph")
            };

            return inscritos;
        }

        public List<InscritoParaSorteio> CargaCsv()
        {
            List<InscritoParaSorteio> inscritos = new List<InscritoParaSorteio>();
            using (StreamReader reader = new StreamReader(@"C:\Projetos\SorteioFacil\Lista.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    //listA.Add(values[0]);
                    inscritos.Add(new InscritoParaSorteio(int.Parse(values[0]), values[1]));
                }

                return inscritos;
            }
        }
    }
}

          

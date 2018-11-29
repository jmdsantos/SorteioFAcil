using System;
using System.Collections.Generic;

namespace SorteioFacil
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sorteio Fácil");
            CarregaLista lista = new CarregaLista();
            List<InscritoParaSorteio> inscritos = lista.Carga();
            //List<InscritoParaSorteio> inscritos = lista.CargaCsv();
            List<InscritoParaSorteio> sorteados = new List<InscritoParaSorteio>();

            Random rnd = new Random();

            bool inscritoSorteado = false;
            bool stop = false;
            string proximo;
            while (stop != true)
            {
                
                int numberSortiado = rnd.Next(1, inscritos.Count + 1);
                
                InscritoParaSorteio result = inscritos.Find(item => item.Numero == numberSortiado);
                if (result == null)
                {
                    break;
                }

                if (sorteados.Count > 0)
                {
                    if (sorteados.Find(item => item.Numero == numberSortiado) == null)
                    {
                        sorteados.Add(new InscritoParaSorteio(result.Numero, result.Nome));
                    }
                    else
                    {
                        Console.WriteLine("Inscrito JÁ sorteado: " + result.Numero + " - " + result.Nome);
                        inscritoSorteado = true;
                    }
                }
                else
                {
                    sorteados.Add(new InscritoParaSorteio(result.Numero, result.Nome));
                }

                if (!inscritoSorteado)
                {
                    Console.WriteLine(result.Numero + " - " + result.Nome);
                    
                }

                inscritoSorteado = false;

                if (sorteados.Count == inscritos.Count)
                {
                    Console.Write("TODOS JÁ FORAM SORTEADOS!");
                    break;
                }
                Console.Write("Proximo sorteio?<S/N>:");
                proximo = Console.ReadLine();

                if (proximo != "S")
                {
                    stop = true;
                }



            }

            Console.ReadLine();
        }
    }
}

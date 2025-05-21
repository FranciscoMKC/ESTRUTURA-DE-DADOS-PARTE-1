using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_DA_PROVA_2
{
    internal class Vetor
    
        namespace ProjetoEstruturas.Estruturas
    {
        public class Vetor
        {
            private int[] elementos;

            public Vetor(int tamanho)
            {
                elementos = new int[tamanho];
            }

            public void Preencher(int[] valores)
            {
                for (int i = 0; i < elementos.Length && i < valores.Length; i++)
                    elementos[i] = valores[i];
            }

            public void Exibir()
            {
                Console.WriteLine("Vetor:");
                foreach (var item in elementos)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }

}


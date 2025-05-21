using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_DA_PROVA_2
{
    internal class Lista
    {
        using System.Collections.Generic;

namespace ProjetoEstruturas.Estruturas
    {
        public class Lista
        {
            private List<int> elementos;

            public Lista()
            {
                elementos = new List<int>();
            }

            public void Adicionar(int valor)
            {
                elementos.Add(valor);
            }

            public void Remover(int valor)
            {
                elementos.Remove(valor);
            }

            public void Exibir()
            {
                Console.WriteLine("Lista:");
                foreach (var item in elementos)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }

}
}

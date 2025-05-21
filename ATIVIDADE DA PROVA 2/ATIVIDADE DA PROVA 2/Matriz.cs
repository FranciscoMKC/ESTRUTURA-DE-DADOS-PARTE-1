using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_DA_PROVA_2
{
    internal class Matriz
    {
        namespace ProjetoEstruturas.Estruturas
    {
        public class Matriz
        {
            private int[,] elementos;

            public Matriz(int linhas, int colunas)
            {
                elementos = new int[linhas, colunas];
            }

            public void Preencher(int[,] valores)
            {
                for (int i = 0; i < elementos.GetLength(0); i++)
                    for (int j = 0; j < elementos.GetLength(1); j++)
                        elementos[i, j] = valores[i, j];
            }

            public void Exibir()
            {
                Console.WriteLine("Matriz:");
                for (int i = 0; i < elementos.GetLength(0); i++)
                {
                    for (int j = 0; j < elementos.GetLength(1); j++)
                        Console.Write(elementos[i, j] + "\t");
                    Console.WriteLine();
                }
            }
        }
    }

}
}

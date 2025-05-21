using System;
using System.Collections.Generic;

namespace MenuEstruturasDados
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal.ExibirMenu();
        }
    }

    public static class MenuPrincipal
    {
        public static void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Vetor.Menu(); break;
                    case "2": Matriz.Menu(); break;
                    case "3": Lista.Menu(); break;
                    case "4": Fila.Menu(); break;
                    case "5": Pilha.Menu(); break;
                    case "6": Pesquisa.Menu(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public static class Vetor
    {
        static List<int> dados = new List<int>();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== VETOR =====");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Exibir");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Buscar(); break;
                    case "0": return;
                }
            }
        }

        static void Inserir()
        {
            Console.Write("Digite o valor: ");
            if (int.TryParse(Console.ReadLine(), out int v)) dados.Add(v);
        }
        static void Remover()
        {
            Console.Write("Digite o índice: ");
            if (int.TryParse(Console.ReadLine(), out int i) && i >= 0 && i < dados.Count)
                dados.RemoveAt(i);
        }
        static void Exibir()
        {
            Console.WriteLine("Elementos do vetor:");
            dados.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int v))
                Console.WriteLine(dados.Contains(v) ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }

    public static class Matriz
    {
        static int[,] mat = new int[3, 3];

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MATRIZ 3x3 =====");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Exibir");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Inserir(); break;
                    case "2": Exibir(); break;
                    case "3": Buscar(); break;
                    case "0": return;
                }
            }
        }

        static void Inserir()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    int.TryParse(Console.ReadLine(), out mat[i, j]);
                }
        }
        static void Exibir()
        {
            Console.WriteLine("Conteúdo da matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            int.TryParse(Console.ReadLine(), out int v);
            bool found = false;
            for (int i = 0; i < 3 && !found; i++)
                for (int j = 0; j < 3 && !found; j++)
                    if (mat[i, j] == v) found = true;

            Console.WriteLine(found ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }

    public static class Lista
    {
        static List<int> lista = new List<int>();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== LISTA =====");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Exibir");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Buscar(); break;
                    case "0": return;
                }
            }
        }

        static void Inserir()
        {
            Console.Write("Digite o valor: ");
            if (int.TryParse(Console.ReadLine(), out int v)) lista.Add(v);
        }
        static void Remover()
        {
            Console.Write("Valor a remover: ");
            if (int.TryParse(Console.ReadLine(), out int v)) lista.Remove(v);
        }
        static void Exibir()
        {
            Console.WriteLine("Elementos da lista:");
            lista.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int v))
                Console.WriteLine(lista.Contains(v) ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }

    public static class Fila
    {
        static Queue<int> fila = new Queue<int>();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== FILA =====");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Exibir");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Buscar(); break;
                    case "0": return;
                }
            }
        }

        static void Inserir()
        {
            Console.Write("Digite o valor: ");
            if (int.TryParse(Console.ReadLine(), out int v)) fila.Enqueue(v);
        }
        static void Remover()
        {
            if (fila.Count > 0) fila.Dequeue();
        }
        static void Exibir()
        {
            Console.WriteLine("Elementos da fila:");
            foreach (var x in fila) Console.WriteLine(x);
            Console.ReadKey();
        }
        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int v))
                Console.WriteLine(fila.Contains(v) ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }

    public static class Pilha
    {
        static Stack<int> pilha = new Stack<int>();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PILHA =====");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Exibir");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Buscar(); break;
                    case "0": return;
                }
            }
        }

        static void Inserir()
        {
            Console.Write("Digite o valor: ");
            if (int.TryParse(Console.ReadLine(), out int v)) pilha.Push(v);
        }
        static void Remover()
        {
            if (pilha.Count > 0) pilha.Pop();
        }
        static void Exibir()
        {
            Console.WriteLine("Elementos da pilha:");
            foreach (var x in pilha) Console.WriteLine(x);
            Console.ReadKey();
        }
        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int v))
                Console.WriteLine(pilha.Contains(v) ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }

    public static class Pesquisa
    {
        static List<int> dados = new List<int> { 1, 3, 5, 7, 9, 11, 13 };

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PESQUISA =====");
                Console.WriteLine("1. Sequencial");
                Console.WriteLine("2. Binária");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                switch (Console.ReadLine())
                {
                    case "1": PesquisaSequencial(); break;
                    case "2": PesquisaBinaria(); break;
                    case "0": return;
                }
            }
        }

        static void PesquisaSequencial()
        {
            Console.Write("Valor: ");
            if (int.TryParse(Console.ReadLine(), out int v))
                Console.WriteLine(dados.Contains(v) ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }

        static void PesquisaBinaria()
        {
            Console.Write("Valor: ");
            if (!int.TryParse(Console.ReadLine(), out int v)) return;

            int ini = 0, fim = dados.Count - 1;
            bool found = false;
            while (ini <= fim)
            {
                int meio = (ini + fim) / 2;
                if (dados[meio] == v) { found = true; break; }
                else if (v < dados[meio]) fim = meio - 1;
                else ini = meio + 1;
            }

            Console.WriteLine(found ? "Encontrado!" : "Não encontrado.");
            Console.ReadKey();
        }
    }
}

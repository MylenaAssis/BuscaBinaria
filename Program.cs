
using System.ComponentModel;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> ListaNumeros = new List<int>();
        ListaNumeros.Add(3);
        ListaNumeros.Add(4);
        ListaNumeros.Add(5);
        ListaNumeros.Add(6);
        ListaNumeros.Add(7);
        ListaNumeros.Add(8);
        ListaNumeros.Add(9);
        ListaNumeros.Add(10);
        ListaNumeros.Add(11);
        ListaNumeros.Add(12);

        int elementoEscolhido = 9;
        int resultado = PesquisaBinaria(ListaNumeros, elementoEscolhido);

        if (resultado != -1)
        {
            Console.WriteLine($"Elemento {elementoEscolhido} encontrado na posição {resultado}.");
        } else
        {
            Console.WriteLine("Elemento não encontrado.");
        }

        static int PesquisaBinaria(List<int> lista, int elementoEscolhido)
        {
            int min = 0;
            int max = lista.Count - 1;
            while (min <= max)
            {
                int meio = (min + max) / 2;
                int chute = lista[meio];
                if (chute == elementoEscolhido)
                {
                    return meio;
                } else if (chute > elementoEscolhido)
                {
                    max = meio - 1;
                }
                else
                {
                    min = meio + 1;
                }
            }
            return -1;
        }
    }
}
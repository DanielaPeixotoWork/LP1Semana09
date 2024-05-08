using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        List<int> lista = new List<int>();
        Stack<int> pilha = new Stack<int>();
        Queue<int> fila = new Queue<int>();
        HashSet<int> conjunto = new HashSet<int>();

        int[] valores = { 1, 10, -30, 10, -5 };

        foreach (int valor in valores)
        {
            lista.Add(valor);
            pilha.Push(valor);
            fila.Enqueue(valor);
            conjunto.Add(valor);
        }

        Console.Write("List: ");
        foreach (int valor in lista)
        {
            Console.Write(valor + ", ");
        }
        Console.WriteLine();

        Console.Write("Stack: ");
        foreach (int valor in pilha)
        {
            Console.Write(valor + ", ");
        }
        Console.WriteLine();

        Console.Write("Queue: ");
        foreach (int valor in fila)
        {
            Console.Write(valor + ", ");
        }
        Console.WriteLine();

        Console.Write("HashSet: ");
        foreach (int valor in conjunto)
        {
            Console.Write(valor + ", ");
        }
        Console.WriteLine();
    }
}

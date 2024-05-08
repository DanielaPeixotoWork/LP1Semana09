using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Por favor, especifique o nome do arquivo como argumento.");
            return;
        }

        string fileName = args[0];
        Queue<string> inputQueue = new Queue<string>();

        Console.WriteLine("Insira as strings (pressione enter após cada uma):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
                break;

            inputQueue.Enqueue(input);
        }

        SaveToFile(fileName, inputQueue);
        Console.WriteLine("Strings salvas com sucesso no arquivo '{0}'", fileName);
    }

    static void SaveToFile(string fileName, Queue<string> queue)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            while (queue.Count > 0)
            {
                writer.WriteLine(queue.Dequeue());
            }
        }
    }
}

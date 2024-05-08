using System;
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

        Console.WriteLine("Insira as strings (pressione enter após cada uma):");

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;

                writer.WriteLine(input);
            }
        }

        Console.WriteLine("Strings salvas com sucesso no arquivo '{0}'", fileName);
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> historicoAcoes = new Stack<string>();
        Queue<string> filaImpressao = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n1. Escrever Texto (Add Ação)");
            Console.WriteLine("2. Desfazer (Undo)");
            Console.WriteLine("3. Enviar para Impressão");
            Console.WriteLine("4. Imprimir Próximo (Impressora)");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a ação feita: ");
                    string acao = Console.ReadLine();
                    historicoAcoes.Push(acao);
                    Console.WriteLine("Ação registrada.");
                    break;

                case "2":
                    if (historicoAcoes.Count > 0)
                    {
                        string desfeita = historicoAcoes.Pop();
                        Console.WriteLine($"Desfeito: {desfeita}");
                    }
                    else Console.WriteLine("Nada para desfazer.");
                    break;

                case "3":
                    Console.Write("Nome do documento: ");
                    string doc = Console.ReadLine();
                    filaImpressao.Enqueue(doc);
                    Console.WriteLine("Documento na fila.");
                    break;

                case "4":
                    if (filaImpressao.Count > 0)
                    {
                        string imp = filaImpressao.Dequeue();
                        Console.WriteLine($"Imprimindo: 📄 {imp}");
                    }
                    else Console.WriteLine("Fila vazia.");
                    break;
            }
        }
    }
}

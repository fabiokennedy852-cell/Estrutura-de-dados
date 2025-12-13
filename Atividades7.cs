using System;
using System.Collections.Generic;

class TabelaHash
{
    private List<string>[] tabela = new List<string>[5];

    public TabelaHash()
    {
        for (int i = 0; i < tabela.Length; i++)
            tabela[i] = new List<string>();
    }

    private int FuncaoHash(string chave)
    {
        return chave.Length % 5;
    }

    public void Adicionar(string palavra)
    {
        int indice = FuncaoHash(palavra);
        tabela[indice].Add(palavra);
        Console.WriteLine($"Palavra {palavra} armazenada no índice {indice}.");
    }

    public void ExibirTabela()
    {
        Console.WriteLine("\n----Estado de Tabela Hash----");
        for (int i = 0; i < tabela.Length; i++)
        {
            Console.WriteLine($"índice {i}:");

            foreach (var item in tabela[i])
            {
                Console.Write($"[{item}]->");
            }
            Console.WriteLine("null");
        }
    }
}

class program
{
    static void Main()
    {
        TabelaHash dicionario = new TabelaHash();

        dicionario.Adicionar("gato");
        dicionario.Adicionar("cachorro");
        dicionario.Adicionar("passaro");
        dicionario.Adicionar("boi");

        dicionario.ExibirTabela();
    }
}

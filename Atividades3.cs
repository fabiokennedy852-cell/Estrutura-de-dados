using System;

public class Node
{
    public string Musica;
    public Node Proxima;
    public Node Anterior;

    public Node(string Musica)
    {
       Musica = Musica;
        Proxima = null;
        Anterior = null;
    }
}

public class Playlist
{
    private Node Inicio;
    private Node Fim;

    public void AdicionarMusica(string nome)
   
    {
        Node novoNo = new Node(nome);

        if (Inicio == null)
        {
            Inicio = novoNo;
            Fim = novoNo;
        }
        else
        {
            Fim.Proxima = novoNo;
            novoNo.Anterior = Fim;
            Fim = novoNo;
        }
        Console.WriteLine($"Música '{nome}' adicionada à playlist.");
    }

    public void TocarPlaylist()
    {
        Console.WriteLine("\n--- Tocando playlist: ---");
        Node atual = Inicio;
        while (atual != null)
        {
            Console.WriteLine($"Tocando: {atual.Musica}");
            atual = atual.Proxima;
        }
        Console.WriteLine("Fim da Playlist.\n");
    }
}

class Program
{
    static void Main()
    {
        Playlist minhaPlaylist = new Playlist();
        minhaPlaylist.AdicionarMusica("Puta Profissional");
        minhaPlaylist.AdicionarMusica("Pepeka Nervosa");
        minhaPlaylist.AdicionarMusica("Boca de Pelo");


        minhaPlaylist.TocarPlaylist();
    }
}

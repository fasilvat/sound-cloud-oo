class Album {

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public int DuracaoTotalComUmaLambda()
    { 
        return musicas.Sum(m => m.Duracao);
    }

    public int DuracaoTotalSemLambda()
    {
        var duracao = 0;
        foreach (var m in musicas)
        {
            duracao += m.Duracao;
        }
        return duracao;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() {

        Console.WriteLine($"Lista de músicas do álbum {Nome}:");

        foreach (var m in musicas) {
            Console.WriteLine(m.Nome);
        }
        Console.WriteLine($"Duração total do álbum em segundos: {DuracaoTotal}");
    }
}
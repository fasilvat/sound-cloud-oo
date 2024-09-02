class Album {

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() {

        Console.WriteLine($"Lista de músicas do álbum {Nome}:");

        foreach (var m in musicas) {
            Console.WriteLine(m.Nome);
        } 
    }
}
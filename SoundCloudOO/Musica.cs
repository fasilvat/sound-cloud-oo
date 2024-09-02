class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set;}
    public int Duracao { get; set;}
    private bool Disponivel { get; set;}

    public string DescricaoResumida { 
        get {
            return $"A música {Nome} pertence à(ao) {Artista}";
        }
    }

    // public void EscreveDisponivel(bool valor)
    // {
    //     disponivel = valor;
    // }

    // public bool LeDisponivel()
    // {
    //     return disponivel;
    // }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Indisponível");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome: {Nome} - Artista: {Artista}");
    }
}
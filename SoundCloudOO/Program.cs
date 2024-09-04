Album album = new Album();
album.Nome = "Imunidade Musical";

Musica musica1 = new Musica();
musica1.Nome = "No passo a passo";
musica1.Duracao = 148;

Musica musica2 = new Musica();
musica2.Nome = "É quente";
musica2.Duracao = 240;

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
album.ExibirMusicasDoAlbum();
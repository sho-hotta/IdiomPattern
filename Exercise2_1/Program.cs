// See https://aka.ms/new-console-template for more information

using Exercise2_1;

var songs = new Song[3];

songs[0] = new Song("melt", "SennaRin", 291);
songs[1] = new Song("Out of the Woods", "Taylor Swift", 236);
songs[2] = new Song("Cage", "SawanoHiroyuki[nZk]", 286);

foreach (var song in songs)
{
    Console.WriteLine($"{song.Title}, {song.ArtistName}, {song.Length / 60}:{song.Length % 60}");
}

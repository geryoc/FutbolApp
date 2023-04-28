namespace FutbolApp.Core.Models;

public class CountryModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<TournamentModel> Tournaments { get; set; } = new List<TournamentModel>();
}

namespace FutbolApp.Core.Models;

public class TournamentModel
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? CountryId { get; set; }

    public CountryModel Country { get; set; }
}
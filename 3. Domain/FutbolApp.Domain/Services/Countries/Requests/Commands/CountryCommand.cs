using System.ComponentModel.DataAnnotations;

namespace FutbolApp.Core.Services.Countries.Requests.Commands
{
    public class CountryCommand
    {
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FutbolApp.Core.Domain.Entities;

public partial class Country
{
    public long Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}

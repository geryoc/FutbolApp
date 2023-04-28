using System;
using System.Collections.Generic;

namespace FutbolApp.Core.Domain.Entities;

public partial class Tournament
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? CountryId { get; set; }

    public virtual Country Country { get; set; }
}

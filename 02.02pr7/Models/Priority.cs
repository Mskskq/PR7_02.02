using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class Priority
{
    public int PriorityId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

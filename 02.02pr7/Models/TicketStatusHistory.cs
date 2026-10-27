using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class TicketStatusHistory
{
    public int HistoryId { get; set; }

    public int? OldStatusId { get; set; }

    public int NewStatusId { get; set; }

    public DateTime ChangedAt { get; set; }

    public int TicketId { get; set; }

    public int ChangedBy { get; set; }

    public virtual Employee ChangedByNavigation { get; set; } = null!;

    public virtual TicketStatus NewStatus { get; set; } = null!;

    public virtual TicketStatus? OldStatus { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;
}

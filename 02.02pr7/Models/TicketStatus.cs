using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class TicketStatus
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TicketStatusHistory> TicketStatusHistoryNewStatuses { get; set; } = new List<TicketStatusHistory>();

    public virtual ICollection<TicketStatusHistory> TicketStatusHistoryOldStatuses { get; set; } = new List<TicketStatusHistory>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int AuthorId { get; set; }

    public int EquipmentId { get; set; }

    public int? AssigneeId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int PriorityId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Employee? Assignee { get; set; }

    public virtual Employee Author { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual Priority Priority { get; set; } = null!;

    public virtual TicketStatus Status { get; set; } = null!;

    public virtual ICollection<TicketStatusHistory> TicketStatusHistories { get; set; } = new List<TicketStatusHistory>();
}

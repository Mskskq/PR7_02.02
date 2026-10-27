using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public int PositionId { get; set; }

    public int DepartmentId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Department Department { get; set; } = null!;

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<Ticket> TicketAssignees { get; set; } = new List<Ticket>();

    public virtual ICollection<Ticket> TicketAuthors { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketStatusHistory> TicketStatusHistories { get; set; } = new List<TicketStatusHistory>();
}

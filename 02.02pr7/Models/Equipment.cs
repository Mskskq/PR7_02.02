using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class Equipment
{
    public int EquipmentId { get; set; }

    public string InventoryNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int DepartmentId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

using System;
using System.Collections.Generic;

namespace _02._02pr7.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}

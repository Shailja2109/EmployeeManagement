using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models;

public partial class Employee
{
    public string? Name { get; set; }

    public DateOnly? BirthDate { get; set; }

    public Guid Id { get; set; }

    public long? Experience { get; set; }

    public Guid Department { get; set; }
}

public partial class EmployeeDTO
{
    public string? Name { get; set; }

    public DateOnly? BirthDate { get; set; }

    public long? Experience { get; set; }

    public Guid Department { get; set; }
}

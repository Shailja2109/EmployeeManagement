using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    public DateOnly? BirthDate { get; set; }

    public long? Experience { get; set; }

    [Required(ErrorMessage = "Department is required")]
    public Guid Department { get; set; }
}

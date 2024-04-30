using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models;

public partial class Department
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Department is required")]
    public string? Name { get; set; }
}

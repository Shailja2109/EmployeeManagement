using System;
using System.Collections.Generic;
using EmployeeManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement;

public partial class Employee
{
    public string? Name { get; set; }

    public string? Department { get; set; }

    public DateOnly? BirthDate { get; set; }

    public Guid Id { get; set; }

    public long? Experience { get; set; }
}

public partial class EmployeeDTO
{
    public string? Name { get; set; }

    public string? Department { get; set; }

    public DateOnly? BirthDate { get; set; }

    public long? Experience { get; set; }
}
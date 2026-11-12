using System;
using System.Collections.Generic;

namespace empApp.Models;

public partial class EmpAppTable
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public DateTime BirthData { get; set; }

    public string Address { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }
}

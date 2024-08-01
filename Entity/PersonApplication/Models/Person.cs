using System;
using System.Collections.Generic;

namespace PersonApplication.Models;

public partial class Person
{
    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string Password { get; set; }

    public string UserName { get; set; }
}

using System;
using System.Collections.Generic;

namespace IceTask3.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Stnumber { get; set; } = null!;

    public string ProfilePicture { get; set; } = null!;
}

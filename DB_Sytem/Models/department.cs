﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_Sytem.Models;

public partial class department
{
    public int dept_ID { get; set; }

    public string name { get; set; }

    public int? manger_ID { get; set; }

    public DateTime? hire_date { get; set; }

    public virtual ICollection<ins_course_dept> ins_course_depts { get; set; } = new List<ins_course_dept>();

    public virtual instructor manger { get; set; }

    public virtual ICollection<student> students { get; set; } = new List<student>();

    public virtual ICollection<branche> branches { get; set; } = new List<branche>();

    public virtual ICollection<instructor> ins { get; set; } = new List<instructor>();
}
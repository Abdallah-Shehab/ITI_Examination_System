﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_Sytem.Models;

public partial class student
{
    public int st_ID { get; set; }

    public string fname { get; set; }

    public string lname { get; set; }

    public int? age { get; set; }

    public string address { get; set; }

    public int? dept_ID { get; set; }

    public virtual department dept { get; set; }

    public virtual ICollection<st_answer> st_answers { get; set; } = new List<st_answer>();

    public virtual ICollection<st_exam> st_exams { get; set; } = new List<st_exam>();

    public virtual ICollection<course> courses { get; set; } = new List<course>();
}
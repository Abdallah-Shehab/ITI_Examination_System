﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_Sytem.Models;

public partial class course_topic
{
    public int course_ID { get; set; }

    public string topic { get; set; }

    public virtual course course { get; set; }
}
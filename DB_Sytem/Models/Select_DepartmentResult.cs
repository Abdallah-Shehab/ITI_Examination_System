﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Sytem.Models
{
    public partial class Select_DepartmentResult
    {
        public int dept_ID { get; set; }
        public string name { get; set; }
        public int? manger_ID { get; set; }
        public DateTime? hire_date { get; set; }
    }
}

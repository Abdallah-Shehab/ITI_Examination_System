﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Sytem.Models
{
    public partial class select_StudentAnswersResult
    {
        public int exam_ID { get; set; }
        public int st_ID { get; set; }
        public int question_ID { get; set; }
        public string answer { get; set; }
        public int? grade { get; set; }
    }
}

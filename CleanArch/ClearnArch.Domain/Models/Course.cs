﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string ImageUrl { get; set; }
    }
}

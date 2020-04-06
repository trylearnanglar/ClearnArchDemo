using ClearnArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearnArch.Appication.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}

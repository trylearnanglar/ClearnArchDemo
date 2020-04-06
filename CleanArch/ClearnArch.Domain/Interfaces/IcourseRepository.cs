using ClearnArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearnArch.Domain.Interfaces
{
    public interface IcourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}

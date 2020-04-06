using ClearnArch.Domain.Interfaces;
using ClearnArch.Domain.Models;
using ClearnArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearnArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}

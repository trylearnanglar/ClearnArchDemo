using ClearnArch.Appication.Interfaces;
using ClearnArch.Appication.ViewModels;
using ClearnArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearnArch.Appication.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}

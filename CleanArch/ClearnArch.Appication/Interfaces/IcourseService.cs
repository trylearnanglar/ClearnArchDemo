﻿using ClearnArch.Appication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearnArch.Appication.Interfaces
{
    public interface IcourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
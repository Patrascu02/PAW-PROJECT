﻿using System.Diagnostics;

namespace PAW_CATALOG_PROJ.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public User Student { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int TeacherId { get; set; }
        public User Teacher { get; set; } = null!;

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;


        // A collection of grades associated with this enrollment
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }

}

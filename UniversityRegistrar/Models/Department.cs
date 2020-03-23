using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Students = new HashSet<Student>();
      this.Courses = new HashSet<Course>();
    }

    public int CourseId { get; set; }
    public string Name {get; set;}
    public string Number { get; set; }
    public virtual ICollection<CourseStudent> Students {get; set;}
  }
}

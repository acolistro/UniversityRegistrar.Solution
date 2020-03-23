using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public Course()
  {
    this.Courses = new HashSet<CourseStudent>();
  }
  
  public int CourseId { get; set; }
  public string Name {get; set;}
  public virtual ICollection<CourseStudent> Students {get; set;}
}
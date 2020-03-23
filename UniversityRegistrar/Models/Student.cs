using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    
    public int StudentId {get; set;}
    
    public string Name {get; set;}

    public Date Date { get; set;}
    
    public int CourseId {get; set;}
    
    public ICollection<CourseStudent> Courses {get;}
  }
}
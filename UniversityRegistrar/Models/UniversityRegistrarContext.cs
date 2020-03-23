namespace UniversityRegistrar.Models
{
  public class UniversityRegistrar
    {       
        public int UniversityRegistrarId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Restaurant Student { get; set; }
        public Cuisine Course { get; set; }
    }
}
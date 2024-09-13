namespace FrontToBack.DataAccessLayer.Entities
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}

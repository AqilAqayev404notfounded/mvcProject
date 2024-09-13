
namespace mvcProject.Models
{
    public class Teacher: Entity
    {
        public string Name { get; set; } = null!;

        public int Age {  get; set; }

        public ICollection<TeacherStudent> Students { get; set; } = new List<TeacherStudent>();


    }
}

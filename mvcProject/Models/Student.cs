
namespace mvcProject.Models;

public class Student : Entity
{
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public int Grade { get; set; }
    public ICollection<TeacherStudent> Students { get; set; }=new List<TeacherStudent>();

    
}

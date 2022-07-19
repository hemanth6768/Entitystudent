using System.ComponentModel.DataAnnotations;

namespace Entitystudent.Model
{
    public class Student
    {
        public string studentname { get; set; }

        [Key]
        public int rollnumber { get; set; } 

        public string section { get; set; } 
    }
}

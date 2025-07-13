namespace _3_EmployeeApi.Models
{
    public class Employee
    {
        public Employee()
        {
            Department = new Department();
            Skills = new List<Skill>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public DateTime DateOfBirth { get; set; }
        }
    
}

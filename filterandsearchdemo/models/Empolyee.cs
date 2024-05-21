using System.ComponentModel.DataAnnotations.Schema;

namespace filterandsearchdemo.models
{
    public class Empolyee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public int Age { get; set; }
        public int performance { get; set; }
        public  string? occuapation { get; set; }
        public Department? Department { get; set; }
    }
}

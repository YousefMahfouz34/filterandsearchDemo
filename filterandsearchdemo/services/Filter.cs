namespace filterandsearchdemo.services
{
    public class Filter
    {
        public List <int>? DepartmentId { get; set; }
        public int? BeginPerformance { get; set; } = 0;
        public int? EndPerformance { get; set; } = 100;
        public List<string>? Occuapation { get; set; }
    }
}

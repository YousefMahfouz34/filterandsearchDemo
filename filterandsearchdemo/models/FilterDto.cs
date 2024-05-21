using filterandsearchdemo.services;

namespace filterandsearchdemo.models
{
    public class FilterDto
    {
        public int pageindex { get; set; } = 1;
        public int itemperpage { get; set; } = 3;
        public Filter? filter { get; set; } = null;
    }
}

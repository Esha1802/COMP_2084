namespace COMP_2084_Assigment.Models.ReferenceTables
{
    public class Country
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProvinceState> ProvinceStates { get; set; }
    }
}

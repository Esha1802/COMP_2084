using COMP_2084_Assigment.Models.PrimaryTables;

namespace COMP_2084_Assigment.Models.ReferenceTables
{
    public class ProvinceState
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public string Code { get; set; }

        //Navigation Properties
        public Country Country { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}

using COMP_2084_Assigment.Models.ReferenceTables;

namespace COMP_2084_Assigment.Models.PrimaryTables
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalZipCode { get; set; }
        public int? ProvinceStateId { get; set; }
        //Navigation Properties
        public ProvinceState ProvinceState { get; set; }
        public Property Property { get; set; }
    }
}

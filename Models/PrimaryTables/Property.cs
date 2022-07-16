using COMP_2084_Assigment.Models.ReferenceTables;

namespace COMP_2084_Assigment.Models.PrimaryTables
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LandlordId { get; set; }
        public int AddressId { get; set; }
        public int BuildingTypeId { get; set; }
        public int UnitTypeId { get; set; }

        public Landlord Landlord { get; set; }
        public BuildingType BuildingType { get; set; }
        public UnitType UnitType { get; set; }
        public Address Address { get; set; }
    }
}

using COMP_2084_Assigment.Models.Property;

namespace COMP_2084_Assigment.Models.PrimaryTables
{
    public class Landlord
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }

        public IEnumerable<Property> Properties { get; set; }
    }
}

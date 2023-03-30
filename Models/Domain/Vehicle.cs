using System.Security;

namespace PassingUpFreights.Models.Domain
{
    public class Vehicle
    {
        public Guid VId { get; set; }
        public string VLicPlate { get; set; }
        public string VModel { get; set; }
        public int VYear { get; set; }
        public string VEngType { get; set; }
        public string VColor { get; set; }
        public int VMileage { get; set; }
        public string VMake { get; set; }
        public string VType { get; set; }
        public string VBooked { get; set; }

    }
}

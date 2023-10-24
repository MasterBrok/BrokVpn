using BrokVpn.Vpn.Enums;

namespace BrokVpn.Vpn.Models
{
    public class Vpn
    {
        public ChoiceContinents? Continent { get; set; }
        public int? Ping { get; set; }
        public bool IsActive { get; set; }
    }
}

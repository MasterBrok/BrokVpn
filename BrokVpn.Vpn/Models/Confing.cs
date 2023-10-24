using System;

namespace BrokVpn.Vpn.Models
{
    public class Confing
    {
        public int IdUser { get; set; }
        public string? StringConnection { get; set; }

        public DateTime Start{ get; set; }
        public DateTime End { get; set; }
    }
}

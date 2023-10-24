using System;

namespace BrokVpn.Vpn.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime FirstLogin { get; set; }
    }
}

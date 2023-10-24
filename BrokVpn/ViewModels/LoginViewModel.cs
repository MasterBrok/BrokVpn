using BrokHelper.Helper;
using BrokVpn.Views;
using BrokVpn.Vpn.Models;
using System.Threading;

namespace BrokVpn.ViewModels
{
    public partial class LoginViewModel : Helper.Notify
    {
        public LoginViewModel()
        {
            User = new();
        }

        private User _user;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                base.BrokNotify();
            }
        }


        public void ClickLogin_Click(object obj)
        {
            if (this.User is { Password: "TheBrokHub", UserName: "TheBrokHub" })
            {
                wVpn? window = new();
                window.Show();
                if (obj is not null)
                    (obj as wLogin).Close();
            }
        }

        public bool CanClickLogin_Click(object obj) => true;


    }
}

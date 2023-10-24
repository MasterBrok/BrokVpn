
using BrokHelper.Helper;
using System.Windows.Input;

namespace BrokVpn.ViewModels
{
    public partial class LoginViewModel
    {
        private ICommand _login;

        public ICommand LoginCommand
        {
            get
            {
                Helper.Command.TryFill(ref _login,new BrokHelper.IBase.IBrokCommand(ClickLogin_Click, CanClickLogin_Click));
                return _login;
            }
        }

    }
}

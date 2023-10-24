using BrokHelper.Helper;
using System;
using System.Windows.Input;

namespace BrokVpn.ViewModels
{
    public partial class VpnViewModel
    {
        private ICommand _cmdConnectVpn;

        public ICommand ConnectVpn
        {
            get
            {
                Helper.Command.TryFill(ref _cmdConnectVpn, new BrokHelper.IBase.IBrokCommand(Connect_Click, CanConnect_Click));
                return _cmdConnectVpn;
            }
        }

    }
}

using BrokHelper.Helper;
using System.Collections.Generic;
using BrokVpn.Vpn.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Documents;
using BrokHelperCustomControlLibrary.Controls.ListBoxs;
using BrokVpn.Controls.BaseControls.ListBoxItems;

namespace BrokVpn.ViewModels
{
    public partial class VpnViewModel : Helper.Notify
    {
        public VpnViewModel()
        {
            VPNs = new ObservableCollection<Vpn.Models.Vpn>()
            {
                new Vpn.Models.Vpn(){IsActive = true,Continent=Vpn.Enums.ChoiceContinents.Europe},
                new Vpn.Models.Vpn(){IsActive = true,Continent=Vpn.Enums.ChoiceContinents.Asia},
                new Vpn.Models.Vpn(){IsActive = true,Continent=Vpn.Enums.ChoiceContinents.Antarctica},

                new Vpn.Models.Vpn(){IsActive = false,Continent=Vpn.Enums.ChoiceContinents.AustraliaOceania},
                new Vpn.Models.Vpn(){IsActive = false,Continent=Vpn.Enums.ChoiceContinents.Africa},
                new Vpn.Models.Vpn(){IsActive = false,Continent=Vpn.Enums.ChoiceContinents.NorthAmerica},
                new Vpn.Models.Vpn(){IsActive = false,Continent=Vpn.Enums.ChoiceContinents.SouthAmerica},
            };
        }

        private ObservableCollection<Vpn.Models.Vpn> _vpns;

        public ObservableCollection<Vpn.Models.Vpn> VPNs
        {
            get { return _vpns; }
            set
            {
                _vpns = value;
                base.BrokNotify();
            }
        }


        private object _selectVpn;

        public object SelectVpn
        {
            get { return _selectVpn; }
            set
            {
                _selectVpn = value;
                this.ConnectVpn_Click(value);
                base.BrokNotify();
            }
        }

        private bool _isConnect = false;

        public bool IsConnect
        {
            get { return _isConnect; }
            set
            {
                _isConnect = value;
                base.BrokNotify();
            }
        }
        private bool CanConnect_Click(object obj) => true;
        private void Connect_Click(object obj)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                IsConnect = IsConnect == true ? false : true;
            });
        }

        private void ConnectVpn_Click(object sender)
        {
            Vpn.Models.Vpn? vpn = (Vpn.Models.Vpn)(sender as ccCountry).DataContext;
        }


    }
}

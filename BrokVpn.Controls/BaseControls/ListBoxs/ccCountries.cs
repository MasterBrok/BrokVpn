using System.Windows;
using System.Windows.Controls;

namespace BrokVpn.Controls.BaseControls.ListBoxs
{
    public class ccCountries : ListBox
    {
        static ccCountries()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccCountries), new FrameworkPropertyMetadata(typeof(ccCountries)));
        }
    }
}

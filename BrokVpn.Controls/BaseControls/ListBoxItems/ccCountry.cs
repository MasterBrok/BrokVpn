
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BrokVpn.Controls.BaseControls.ListBoxItems
{
    public class ccCountry : ListBoxItem
    {
        static ccCountry()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccCountry), new FrameworkPropertyMetadata(typeof(ccCountry)));
        }


        public SolidColorBrush SelectColor
        {
            get { return (SolidColorBrush)GetValue(SelectColorProperty); }
            set { SetValue(SelectColorProperty, value); }
        }

        public static readonly DependencyProperty SelectColorProperty =
            DependencyProperty.Register("SelectColor", typeof(SolidColorBrush), typeof(ccCountry), new PropertyMetadata(default));


    }
}

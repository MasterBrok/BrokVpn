using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace BrokVpn.Controls.BaseControls.Buttons
{
     public class ccButtonRadius : ToggleButton
    {
        static ccButtonRadius()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccButtonRadius), new FrameworkPropertyMetadata(typeof(ccButtonRadius)));
        }


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ccButtonRadius), new PropertyMetadata(default));


    }
}

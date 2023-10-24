
using System.Windows;
using System.Windows.Controls;
namespace BrokVpn.Controls.BaseControls.TextBoxs
{

    public class ccTextBox : TextBox
    {
        static ccTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccTextBox), new FrameworkPropertyMetadata(typeof(ccTextBox)));
        }




        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(ccTextBox), new PropertyMetadata(default));



    }
}


using System.Windows;
using System.Windows.Controls;

namespace BrokHub_CSA.BaseControls.ControlTextBoxs
{
    public class ccTextBox : TextBox
    {
        static ccTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccTextBox), new FrameworkPropertyMetadata(typeof(ccTextBox)));
        }
    }
}

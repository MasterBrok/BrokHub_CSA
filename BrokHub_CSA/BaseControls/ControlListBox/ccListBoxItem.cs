
using System.Windows;
using System.Windows.Controls;

namespace BrokHub_CSA.BaseControls.ControlListBox
{
    
    public class ccListBoxItem : ListBoxItem
    {
        static ccListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccListBoxItem), new FrameworkPropertyMetadata(typeof(ccListBoxItem)));
        }
    }
}

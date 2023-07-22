using System.Windows;
using System.Windows.Controls;

namespace BrokHub_CSA.BaseControls.ControlMenu
{
    
    public class ccMenu : Menu
    {
        static ccMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccMenu), new FrameworkPropertyMetadata(typeof(ccMenu)));
        }
    }
}

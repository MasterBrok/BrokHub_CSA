
using System.Windows;
using System.Windows.Controls;

namespace BrokHub_CSA.BaseControls.ControlButtons
{
  
    public class ccButtonConvert : Button
    {
        static ccButtonConvert()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccButtonConvert), new FrameworkPropertyMetadata(typeof(ccButtonConvert)));
        }
    }
}

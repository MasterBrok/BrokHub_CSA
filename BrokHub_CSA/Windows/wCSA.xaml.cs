using System.Windows;

namespace BrokHub_CSA.Windows
{
    /// <summary>
    /// Interaction logic for wCSA.xaml
    /// </summary>
    public partial class wCSA : Window
    {
        public wCSA()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }
    }
}

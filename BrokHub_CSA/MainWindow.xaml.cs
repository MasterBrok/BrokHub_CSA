
using CSA.Enums;
using CSA.Models;
using CSA.Patterns;
using System.Windows;


namespace BrokHub_CSA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PatternTag tag = new PatternTag(new Content()
            {
                Input = "Brok",
                Output = "",
                Animation = new Animation()
                {
                    Name = CSA.Enums.EnumAnimation.StringAnimationUsingKeyFrames,
                    JumpTime = 0,
                    Value = "",
                    TypeFrame = EnumType.StringKeyFrame,
                    EnumKey = CSA.Enums.EnumKeyFrames.Discrete
                }
            });
            string a = tag.Frame();
            MessageBox.Show(a);
        }
    }
}

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatAppUI.UserControls
{
    /// <summary>
    /// Interaction logic for UserImage.xaml
    /// </summary>
    public partial class UserImage : UserControl
    {
        public UserImage()
        {
            InitializeComponent();
        }

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(UserImage));
    }
}

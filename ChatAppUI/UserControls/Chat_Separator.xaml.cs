using System.Windows;
using System.Windows.Controls;

namespace ChatAppUI.UserControls
{
    /// <summary>
    /// Interaction logic for Chat_Separator.xaml
    /// </summary>
    public partial class Chat_Separator : UserControl
    {
        public Chat_Separator()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Chat_Separator));
    }
}

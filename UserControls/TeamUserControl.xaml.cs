using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP_Practice_10.UserControls
{
    public partial class TeamUserControl : UserControl
    {
        public TeamUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(TeamUserControl));

        public string Num
        {
            get => (string)GetValue(NumProperty);
            set => SetValue(NumProperty, value);
        }
        public static readonly DependencyProperty NumProperty =
            DependencyProperty.Register("Num", typeof(string), typeof(TeamUserControl));

        public ImageSource Source
        {
            get => (ImageSource)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(TeamUserControl));
    }
}

using System.Windows;
using System.Windows.Controls;

namespace TaxExtractor.UserControls
{
    /// <summary>
    /// Lógica de interacción para ListItem.xaml
    /// </summary>
    public partial class ListItem : UserControl
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(ListItem));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(ListItem));

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ListItem()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}

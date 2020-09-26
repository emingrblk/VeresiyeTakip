using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace $rootnamespace$
{
    /// <summary>
    /// Interaction logic for $toolBoxControl$.xaml.
    /// </summary>
    [ProvideToolboxControl("$rootnamespace$.$toolBoxControl$", true)]
    public partial class $toolBoxControl$ : UserControl
    {
        public $toolBoxControl$()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "$message$", this.ToString()));
        }
    }
}

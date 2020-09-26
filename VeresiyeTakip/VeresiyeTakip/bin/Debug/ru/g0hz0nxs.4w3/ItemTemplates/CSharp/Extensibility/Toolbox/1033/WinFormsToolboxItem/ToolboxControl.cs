using System.Globalization;
using System;
using System.Windows.Forms;

namespace $rootnamespace$
{
    [ProvideToolboxControl("$rootnamespace$.$toolBoxControl$", false)]
    public partial class  $toolBoxControl$ : UserControl
    {
        public  $toolBoxControl$()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "$message$", this.ToString()));
        }
    }
}

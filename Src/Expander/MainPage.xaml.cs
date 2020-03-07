using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expander.Model;
using Xamarin.Forms;

namespace Expander
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Report expandedReport;

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            var newReport = (sender as View).BindingContext as Report;

            if(expandedReport != null)
            {
                expandedReport.IsExpanded = false;

                if(expandedReport == newReport)
                {
                    expandedReport = null;
                    return;
                }
            }

            if(newReport != null)
            {
                newReport.IsExpanded = true;
                expandedReport = newReport;
            }
        }
    }
}

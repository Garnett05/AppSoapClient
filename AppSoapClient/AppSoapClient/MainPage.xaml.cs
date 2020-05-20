using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSoapClient
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

        private void ActionSendValues (object sender, EventArgs args)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);            
            txtResult.Text = DependencyService.Get<IServiceSOAP>().Add(num1, num2);
        }
    }
}

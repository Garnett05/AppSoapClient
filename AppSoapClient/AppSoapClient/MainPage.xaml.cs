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
            List<string> list = new List<string>();
            list.Add("Add");
            list.Add("Sub");
            list.Add("Mult");
            list.Add("Div");
            pickerOperation.ItemsSource = list;
            pickerOperation.SelectedIndex = 0;
        }

        private void ActionChangedPickerIndex(object sender, EventArgs args)
        {
            Picker pk = (Picker)sender;
            if (pk.SelectedIndex == 0)
            {
                lblOperation.Text = "Add";
                lblOperator.Text = "+";

            }
            else if (pk.SelectedIndex == 1)
            {
                lblOperation.Text = "Sub";
                lblOperator.Text = "-";
            }
            else if (pk.SelectedIndex == 2)
            {
                lblOperation.Text = "Mult";
                lblOperator.Text = "x";
            }
            else
            {
                lblOperation.Text = "Div";
                lblOperator.Text = "/";
            }
        }
        private void ActionCalculate(object sender, EventArgs args)
        {
            try
            {
                int num1 = int.Parse(number1.Text);
                int num2 = int.Parse(number2.Text);
                var depServ = DependencyService.Get<IServiceSOAP>();
                if (pickerOperation.SelectedIndex == 0)
                {
                    txtResult.Text = depServ.Add(num1, num2);
                }
                else if (pickerOperation.SelectedIndex == 1)
                {
                    txtResult.Text = depServ.Subtract(num1, num2);
                }
                else if (pickerOperation.SelectedIndex == 2)
                {
                    txtResult.Text = depServ.Multiply(num1, num2);
                }
                else
                {
                    txtResult.Text = depServ.Divide(num1, num2);
                }
                lblError.Text = string.Empty;
            }
            catch (ArgumentNullException e)
            {
                lblError.Text = e.Message;
            }
            catch (FormatException e)
            {
                lblError.Text = e.Message;
            }

        }
    }
}

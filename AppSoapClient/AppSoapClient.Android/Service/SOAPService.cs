using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly:Xamarin.Forms.Dependency(typeof(AppSoapClient.Droid.Service.SOAPService))]
namespace AppSoapClient.Droid.Service
{
    public class SOAPService : IServiceSOAP
    {
        public string Add (int n1, int n2)
        {
            var service = new com.dneonline.Calculator();
            int result = service.Add(n1, n2);
            return "= " + result;
        }
        public string Subtract(int n1, int n2)
        {
            var service = new com.dneonline.Calculator();
            int result = service.Subtract(n1, n2);
            return "= " + result;
        }
        public string Multiply(int n1, int n2)
        {
            var service = new com.dneonline.Calculator();
            int result = service.Multiply(n1, n2);
            return "= " + result;
        }
        public string Divide(int n1, int n2)
        {
            var service = new com.dneonline.Calculator();
            int result = service.Divide(n1, n2);
            return "= " + result;
        }
    }
}
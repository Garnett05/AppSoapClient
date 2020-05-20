using System;
using System.Collections.Generic;
using System.Text;

namespace AppSoapClient
{
    public interface IServiceSOAP
    {
        string Add(int n1, int n2);
        string Subtract(int n1, int n2);
        string Multiply(int n1, int n2);
        string Divide(int n1, int n2);
    }
}

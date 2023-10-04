using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public class ValidationClass : ValidationRule
    {
        public static string toValidate = "";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value != null)
                MessageBox.Show("Lipa");
            return new ValidationResult(false, "Check");
        }
    }
}

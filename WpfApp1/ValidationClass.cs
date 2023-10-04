using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public class ValidationClass : ValidationRule
    {
        public string toValidate { get; set; }

        public ValidationClass()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        { 
            try
            {
                Regex regex = new Regex("[A-Z][a-z]+");
                if (!regex.IsMatch((string)value))
                    return new ValidationResult(false, $"Błędnie wpisane dane.");

            }
            catch (Exception e)
            {
                return new ValidationResult(false, $"Błąd: {e.Message}");
            }

            return ValidationResult.ValidResult;
        }
    }
}

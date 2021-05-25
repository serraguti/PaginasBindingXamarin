using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConverterImages : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int numero = (int)value;
            if (numero > 0)
            {
                return "arriba.jpg";
            }
            else
            {
                return "https://images.emojiterra.com/twitter/v13.0/512px/2b07.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

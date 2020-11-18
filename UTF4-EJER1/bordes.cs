
using System;
using System.Globalization;
using System.Windows.Data;

namespace UTF4_EJER1
{
    class bordes : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int borde = 3;
            return borde;
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int borde = 0;
            return borde;
        }
    }


}

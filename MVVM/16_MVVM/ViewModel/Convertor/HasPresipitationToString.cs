using System;
using System.Globalization;
using System.Windows.Data;

namespace _16_MVVM.ViewModel.Convertor
{
    public class HasPresipitationToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "Precipitation: None";
            else
                return "Precipitation: Yes";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

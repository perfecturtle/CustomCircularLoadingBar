using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPFSpinner.Converters
{
    public class DoubleToDurationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Duration duration = new Duration(TimeSpan.FromSeconds((double)value));
            return duration;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

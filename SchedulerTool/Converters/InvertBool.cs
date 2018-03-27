using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace SchedulerTool.Converters
{
    public class InvertBool : MarkupExtension, IValueConverter
    {
        private static InvertBool _converter;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && !(bool) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _converter ?? (_converter = new InvertBool());
        }
    }
}
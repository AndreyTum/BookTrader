using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BookTrader.Helpers
{
    class DateTimeOffsetToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is null)
            {
                return null;
            }

            if (value is DateTime)
            {
                return new DateTimeOffset((DateTime)value);
            }

            throw new ArgumentException("value is not DateTimeOffset");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is null)
            {
                return null;
            }

            if (value is DateTimeOffset)
            {
                return ((DateTimeOffset)value).DateTime;
            }

            throw new ArgumentException("value is not DateTime");
        }
    }
}

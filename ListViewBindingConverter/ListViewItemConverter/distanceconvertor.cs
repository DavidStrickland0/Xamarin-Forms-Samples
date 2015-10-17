using System;

using Xamarin.Forms;
using System.Globalization;
using System.Diagnostics;

namespace ListViewItemConverter
{
	class DistanceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string result;
			//value is set to null
			if (value == null)
				result = "Im Null";
			else
				result = "Im Not";

			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}



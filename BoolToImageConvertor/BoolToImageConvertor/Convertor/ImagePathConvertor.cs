using System;
using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public class ImagePathConvertor : IValueConverter
	{
		public ImagePathConvertor()
		{
			System.Diagnostics.Debug.WriteLine("t");
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value is bool)  {

				if((bool)value == true)
					return "noci.png";
				else
					return "icon.png";
			}
			return "";
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}


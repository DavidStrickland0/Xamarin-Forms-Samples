﻿using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace AddToList
{
	public class ImagePathConvertor : IValueConverter
	{
		public ImagePathConvertor(){}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if ((bool)value) {
				return "minus";
			}
			else
			{
				return "add";
			}
				

		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}


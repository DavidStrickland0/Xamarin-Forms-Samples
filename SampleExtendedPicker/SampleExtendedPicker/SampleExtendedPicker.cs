using System;

using Xamarin.Forms;
using XLabs.Forms.Controls;
using System.Collections.Generic;
using XLabs.Sample.Pages.Controls;

namespace SampleExtendedPicker
{
	public class App : Application
	{
		public App ()
		{
			var extenderPicker = new ExtendedPicker ();
			extenderPicker.ItemsSource = new List<Color>{ Color.Aqua, Color.Black };

			// The root page of your application
			MainPage = new ExtendedPickerPage();
			}
		}
	}



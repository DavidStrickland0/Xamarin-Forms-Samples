using System;

using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public class Account : ContentPage
	{
		public Account ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}



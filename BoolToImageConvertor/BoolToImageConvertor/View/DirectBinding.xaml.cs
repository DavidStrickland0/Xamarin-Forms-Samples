using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public partial class DirectBinding : ContentPage
	{
		public DirectBinding ()
		{
			InitializeComponent ();
			this.BindingContext = new SmartViewModel ();
		}
	}
}


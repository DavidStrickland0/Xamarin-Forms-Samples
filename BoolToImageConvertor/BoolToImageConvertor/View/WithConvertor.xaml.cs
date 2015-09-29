using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public partial class WithConvertor : ContentPage
	{
		public WithConvertor ()
		{
			InitializeComponent ();
			this.BindingContext = new DumbViewModel();

		}
	}
}


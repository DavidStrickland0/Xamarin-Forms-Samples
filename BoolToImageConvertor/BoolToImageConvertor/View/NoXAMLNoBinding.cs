using System;

using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class NoXAMLDirectBinding : ContentPage
	{
		
		public NoXAMLDirectBinding ()
		{
			this.BindingContext = new DumbViewModel ();
			Image img = new Image ();
			((DumbViewModel)this.BindingContext).PropertyChanged += (sender, e) => {
				if (((DumbViewModel)sender).BoolOnOff)
					img.Source = "noci.png";
				else
					img.Source = "icon.png";

			};

			Switch switchView = new Switch();
			switchView.SetBinding<DumbViewModel> (Switch.IsToggledProperty,dvm=>dvm.BoolOnOff);

			this.Content  = new StackLayout {
					Children = {
						img,
						switchView
					}
			};
		}
	}
}



using System;

using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class NoXAMLNoBinding : ContentPage
	{
		
		public NoXAMLNoBinding ()
		{
			this.BindingContext = new DumbViewModel ();
			Image img = new Image{Source="icon.png"};

			((DumbViewModel)this.BindingContext).PropertyChanged += (sender, e) => {
				if (((DumbViewModel)sender).BoolOnOff)
					img.Source = "icon.png";
				else
					img.Source = "noci.png";
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



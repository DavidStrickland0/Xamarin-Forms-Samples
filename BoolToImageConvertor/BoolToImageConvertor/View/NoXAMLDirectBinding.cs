using System;

using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class NoXAMLDirectBinding : ContentPage
	{
		public NoXAMLDirectBinding ()
		{
			this.BindingContext = new SmartViewModel ();
			Image img = new Image ();
			img.SetBinding<SmartViewModel> (Image.SourceProperty,dvm=>dvm.ImagePath);


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



using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoolToImageConvertor
{
	public class NoXAMLWithConvertor : ContentPage
	{
		
		public NoXAMLWithConvertor ()
		{
			this.BindingContext = DumbViewModel ();

			Image img = new Image ();
			img.SetBinding<SmartViewModel>(Image.SourceProperty,dvm=>dvm.BoolOnOff,0,new ImagePathConvertor());

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



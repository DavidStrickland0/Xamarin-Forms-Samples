using System;

using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public class NoXAML : ContentPage
	{
		
		public NoXAML ()
		{
			this.BindingContext = new DumbViewModel ();
			Image img = new Image ();
			img.SetBinding<DumbViewModel>(Image.SourceProperty,dvm=>dvm.BoolOnOff,0,new ImagePathConvertor());
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



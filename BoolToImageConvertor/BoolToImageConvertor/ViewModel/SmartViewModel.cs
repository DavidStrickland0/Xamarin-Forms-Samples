using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class DumbViewModelNoXaml :INotifyPropertyChanged 
	{
		public DumbViewModelNoXaml (){}


		private string imagePath="icon.png";
		public string ImagePath {
			get { return imagePath; } 
			set { 
				imagePath = value; 
				RaisePropertyChanged ("ImagePath");
			}
		}

		private bool boolOnOff;
		public bool BoolOnOff {
			get { return boolOnOff; } 
			set { 
				boolOnOff = value; 
				RaisePropertyChanged ("BoolOnOff");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string name)
		{

			if (name == "BoolOnOff") {
				if (BoolOnOff)
					ImagePath = "noci.png";
				else
					ImagePath = "icon.png";
			}

			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}



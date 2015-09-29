using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class SmartViewModel :INotifyPropertyChanged 
	{
		Account model;
		public SmartViewModel (){
			//Normally a call into a UOW etc to retrieve your data.
			model = new Account ();
		}


		private string imagePath="icon.png";
		public string ImagePath {
			get { return imagePath; } 
			set { 
				imagePath = value; 
				RaisePropertyChanged ("ImagePath");
			}
		}

		public bool BoolOnOff {
			get { return model.IsActive; } 
			set { 
				model.IsActive = value; 
				RaisePropertyChanged ("BoolOnOff");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string name)
		{

			if (name == "BoolOnOff") {
				if (BoolOnOff)
					ImagePath = "icon.png";
				else
					ImagePath = "noci.png";
			}

			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}



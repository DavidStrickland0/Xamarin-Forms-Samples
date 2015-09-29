using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class DumbViewModel :INotifyPropertyChanged 
	{
		public DumbViewModel (){}


		private string imagePath="icon.png";
		public string ImagePath {
			get { return imagePath; } 
			set { 
				imagePath = value; 
				RaisePropertyChanged (" ImagePath");
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
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}



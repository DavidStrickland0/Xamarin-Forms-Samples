using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace BoolToImageConvertor
{
	public class DumbViewModel :INotifyPropertyChanged 
	{
		Account model;
		public DumbViewModel (){
			//Normally a call into a UOW etc to retrieve your data.
			model = new Account ();
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
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}



using System;
using System.ComponentModel;

namespace AddToList
{
	public class ItemForSale:INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		public ItemForSale ()
		{
		}
		public string Name {
			get;
			set;
		}

		public double Price {
			get;
			set;
		}

		private bool isAddedToCart;
		public bool IsAddedToCart {
				get{return isAddedToCart;}
				set{
				isAddedToCart = value;
				OnPropertyChanged ("IsAddedToCart");
			}
		}
			private void OnPropertyChanged(string propertyName)
			{
				if(PropertyChanged!=null)
				{
				PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
				}
			}
	}
}


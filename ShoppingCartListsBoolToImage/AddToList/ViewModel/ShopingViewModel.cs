using System;
using System.Collections.ObjectModel;

namespace AddToList
{
	public class ShopingViewModel
	{
		public ShopingViewModel ()
		{
			///Initialize it with some data
			ItemsForSale = new ObservableCollection<ItemForSale> () {
				new ItemForSale{ Name = "Item 1",	Price = 1.1 },
				new ItemForSale{ Name = "Item 2",	Price = 2.1 },
				new ItemForSale{ Name = "Item 3",	Price = 3.1 },
				new ItemForSale{ Name = "Item 4",	Price = 4.1 },
				new ItemForSale{ Name = "Item 5",	Price = 5.1 },
				new ItemForSale{ Name = "Item 6",	Price = 6.1 },
				new ItemForSale{ Name = "Item 7",	Price = 7.1 },
				new ItemForSale{ Name = "Item 8",	Price = 8.1 }
			};

		}

		public ObservableCollection<ItemForSale> ItemsForSale
		{
			get;
			set;
			
		}
	}
}


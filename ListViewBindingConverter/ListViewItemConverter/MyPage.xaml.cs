using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListViewItemConverter
{
	public partial class MyPage : ContentPage
	{

		public class Place
		{
			public string Name{ get; set;}
			public string Date{ get; set;}
			public DateTime Time{ get; set;}
		}

		public MyPage()
		{
			InitializeComponent ();
			Places = new ObservableCollection<Place>();
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			Places.Add (new Place{ Name = "Name", Date = DateTime.Now.Date.ToString(), Time = DateTime.Now.ToLocalTime() });
			BindingContext = this;
		}
		public ObservableCollection<Place> Places { get; set; }
	}
}


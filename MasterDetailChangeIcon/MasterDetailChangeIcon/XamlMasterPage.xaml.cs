using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Collections.ObjectModel; 
using Xamarin.Forms;

namespace MasterDetailChangeIcon
{

	public partial class XamlMasterPage : MasterDetailPage
	{
		DataClass dataClass;
		DataClass DataClass { 
			get{
				if (dataClass == null) {
					dataClass = new DataClass ();
				}
				return dataClass;
			} 
			set{
				dataClass=value;
				OnPropertyChanged ("DataClass");
			}
				 
		}

		public XamlMasterPage ()
		{
			InitializeComponent ();
			this.IsPresented = true;
			this.BindingContext = DataClass;
				
			if (Device.OS != TargetPlatform.iOS)
			{
				TapGestureRecognizer tap = new TapGestureRecognizer();
				tap.Tapped += (sender, args) =>
				{
					this.IsPresented = true;
				};

				((ContentPage)this.Detail).Content.BackgroundColor = Color.Transparent;
				((ContentPage)this.Detail).Content.GestureRecognizers.Add(tap);
			}
			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

			((DataClass)this.BindingContext).PropertyChanged += (sender, e) => {
				listView.ItemsSource = null;
				listView.ItemsSource = DataClass.NamedColors;
			};

			this.IsPresentedChanged += (sender, e) => {
				if (!IsPresented) {
					((NamedColor)listView.SelectedItem).Name = ((NamedColor)listView.SelectedItem).Name.ToLower (); 
					((NamedColor)listView.SelectedItem).IsViewed=true;
				}
				OnPropertyChanged("DataClass");
				this.BindingContext = null;
			};
		}
	}
}


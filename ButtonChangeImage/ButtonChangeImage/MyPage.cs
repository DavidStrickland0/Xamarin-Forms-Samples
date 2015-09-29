using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ButtonChangeImage
{
	public class MyPage : ContentPage
	{
		ObservableCollection<string> listToWatch = new ObservableCollection<string> ();
		public MyPage ()
		{
			Button buttonToUpdate = new Button {Text = "Image Button",  Image = "icon.png"};
			Button UpdatesList = new Button {Text="Add Item to list"};
			buttonToUpdate.SetBinding (Button.ImageProperty, new Binding("ImagePath"));
			UpdatesList.Clicked += (sender,e) => {
				listToWatch.Add (DateTime.Now.ToString());
			};
			listToWatch.CollectionChanged+=(sender,e)=>{
				if(	listToWatch.Count%2==1)
				{
					ImagePath="noci.png";		
				}
				else
				{
					ImagePath="icon.png";
				}
			};
			Content = new StackLayout { 
				Children = {
					buttonToUpdate,
					UpdatesList
				}
			};
			Content.BindingContext = this;
		}
		private string imagePath="icon.png";
		public string ImagePath {
		    get { return imagePath; } 
		    set { 
		    imagePath = value; 
			OnPropertyChanged ("ImagePath");
		    }
		}
	}
}



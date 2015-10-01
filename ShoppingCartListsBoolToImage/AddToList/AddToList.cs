using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace AddToList
{
	public class App : Application
	{
		public ObservableCollection<ItemForSale> CartCollection {
			get;
			set;
		}

		private ListView forSale;
		private ListView cart ;
		public App ()
		{
			CartCollection = new ObservableCollection<ItemForSale>();
//			CartCollection.CollectionChanged += (sender, e) => {
//				forSale.ItemsSource=null;
//				forSale.ItemsSource = ((ShopingViewModel)BindingContext).ItemsForSale;
//			}; 


			this.BindingContext = new ShopingViewModel ();

			// The root page of your application
			var grid = new Grid {
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = { new RowDefinition{ Height = GridLength.Auto } ,
				 new RowDefinition{ Height = new GridLength (1, GridUnitType.Star) } },
				ColumnDefinitions = {
					new ColumnDefinition{ Width = new GridLength(1,GridUnitType.Star) },
					new ColumnDefinition{ Width = new GridLength(1,GridUnitType.Star) }
				}
			};
			forSale = new ListView (){
				BackgroundColor=Color.Red,
				ItemTemplate = new DataTemplate(() =>
					{
						// Create views with bindings for displaying each property.
						Label nameLabel = new Label();
						nameLabel.SetBinding(Label.TextProperty, "Name");

						Label priceLabel = new Label(){HorizontalOptions=LayoutOptions.End};
						priceLabel.SetBinding(Label.TextProperty,"Price");
					
						Image addedorNot = new Image();
						var addedOrNotImageBinding = new Binding("IsAddedToCart",0, new ImagePathConvertor());
						addedorNot.SetBinding(Image.SourceProperty,addedOrNotImageBinding);

						var vc= new ViewCell
						{
							View = new StackLayout
							{
								Orientation = StackOrientation.Horizontal,
								Children = 
								{
									new StackLayout
									{
										Orientation=StackOrientation.Horizontal,
										VerticalOptions = LayoutOptions.Center,
										Spacing = 0,
										Children = 
										{
											addedorNot,
											nameLabel
										}
										}
								}
								}
						};




						vc.Tapped+=(s,e)=>{
							ViewCell viewCell = (ViewCell)s;
							ItemForSale item = (ItemForSale)viewCell.BindingContext;
							if(item.IsAddedToCart)
							{
								item.IsAddedToCart = false;
								CartCollection.Remove(item);
							}
							else
							{
								item.IsAddedToCart = true;
								CartCollection.Add(item);
							}
						};	
						return vc;
					})
						
			
			};
			forSale.SetBinding(ListView.ItemsSourceProperty,new Binding("ItemsForSale"));

			cart = new ListView (){
				BackgroundColor=Color.Green,
					ItemTemplate = new DataTemplate(() =>
						{


							// Create views with bindings for displaying each property.
							Label nameLabel = new Label();
							nameLabel.SetBinding(Label.TextProperty, "Name");

							Label priceLabel = new Label(){HorizontalOptions=LayoutOptions.End};
							priceLabel.SetBinding(Label.TextProperty,"Price");

							var vc= new ViewCell
							{
								View = new StackLayout
								{
									Orientation = StackOrientation.Horizontal,
									Children = 
									{
										new StackLayout
										{
											Orientation=StackOrientation.Horizontal,
											VerticalOptions = LayoutOptions.Center,
											Spacing = 0,
											Children = 
											{
											
												nameLabel,
												priceLabel
											}
											}
									}
									}
							};
							return vc;
						})



			};
			grid.Children.Add (cart, 1, 1);
			grid.Children.Add (new Label (){Text="For Sale",HorizontalOptions =LayoutOptions.CenterAndExpand}, 0, 0);
			grid.Children.Add (new Label (){Text="Cart",HorizontalOptions=LayoutOptions.CenterAndExpand}, 1, 0);

			MainPage = new ContentPage {
				Content = grid
			};
			Binding cartBinding = new Binding ();
			cartBinding.Source = CartCollection;

			cart.SetBinding(ListView.ItemsSourceProperty,cartBinding);
			grid.Children.Add (forSale, 0, 1);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


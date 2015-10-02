using System;

using Xamarin.Forms;
using System.Windows.Input;

namespace ToggleSwitchBinding
{
	public class App : Application
	{
		public ICommand ToggleIt{get;set;}
		public App ()
		{
			ToggleIt = new Command (() => IsToggled = !IsToggled);


			SwitchCell mySwitch = new SwitchCell ();
			mySwitch.SetBinding (SwitchCell.OnProperty , "IsToggled", 0); 
			var myButton = new Button(){
				Text="CLICK IT! CLICK IT! CLICK IT!  YOU KNOW YOU WANT TO",
				Command = ToggleIt};

			MainPage = new ContentPage {
				BindingContext = this,
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						myButton,
						new TableView
						{
							Intent = TableIntent.Form,
							Root = new TableRoot
							{
								new TableSection
								{
									mySwitch
								}
							}
						}
					}
				}
			};
		}

		private bool isToggled;
		public bool IsToggled
		{
			get{return isToggled;}
			set{isToggled = value;
				OnPropertyChanged("IsToggled");
			}
		}



	}
}


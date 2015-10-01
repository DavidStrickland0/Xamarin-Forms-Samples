using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Collections.ObjectModel; 
using Xamarin.Forms;


namespace MasterDetailChangeIcon
{
		public class DataClass
		{

			private ObservableCollection<NamedColor> namedColors;
			public ObservableCollection<NamedColor> NamedColors
			{
				get{
					if(namedColors==null)
					{
						namedColors = new ObservableCollection<NamedColor> {
							new NamedColor ("Aqua", Color.Aqua),
							new NamedColor ("Black", Color.Black),
							new NamedColor ("Blue", Color.Blue),
							new NamedColor ("Fuschia", Color.Fuchsia),
							new NamedColor ("Gray", Color.Gray),
							new NamedColor ("Green", Color.Green),
							new NamedColor ("Lime", Color.Lime),
							new NamedColor ("Maroon", Color.Maroon),
							new NamedColor ("Navy", Color.Navy),
							new NamedColor ("Olive", Color.Olive),
							new NamedColor ("Purple", Color.Purple),
							new NamedColor ("Red", Color.Red),
							new NamedColor ("Silver", Color.Silver),
							new NamedColor ("Teal", Color.Teal),
							new NamedColor ("White", Color.White),
							new NamedColor ("Yellow", Color.Yellow)
						};
						foreach(NamedColor color in namedColors)
						{
							color.PropertyChanged += (sender, e) => {
								OnPropertyChanged ("NamedColors");
							};
						}
					};
					return namedColors;
				}
			}

			private NamedColor detailData;
			public NamedColor DetailData
			{
				get{
					if (detailData == null) {
						detailData = new NamedColor ("Yellow", Color.Yellow);
					}
					return detailData;
				}
				set
				{
					detailData = value;
					OnPropertyChanged ("DetailData");
				}
			}

			protected void OnPropertyChanged(string propertyName)
			{
				PropertyChangedEventHandler handler = PropertyChanged;
				if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
			}
			public event PropertyChangedEventHandler PropertyChanged;
		}

	}



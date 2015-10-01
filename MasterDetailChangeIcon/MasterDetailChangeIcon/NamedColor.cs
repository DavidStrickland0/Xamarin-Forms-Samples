using System;
using System.ComponentModel; 
using Xamarin.Forms;

namespace MasterDetailChangeIcon
{
    // Used in TabbedPageDemoPage & CarouselPageDemoPage.
    public class NamedColor
    {
        public NamedColor(string name, Color color)
        {
            this.Name = name;
            this.Color = color;
        }

		private string name;
        public string Name 
		{ 
			set{ name = value; 
				OnPropertyChanged ("Name");
			} 
			get{ return name; } 
		}
		private bool isViewed;
		public bool IsViewed {
			get{ return isViewed; }
			set{isViewed = value;
				OnPropertyChanged ("IsViewed");
			}
		}
		private Color color;
        public Color Color { 
			set{color = value;
				OnPropertyChanged ("Color");
			} 
			get{return color;} 
		}
		protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
		public event PropertyChangedEventHandler PropertyChanged;

		public override string ToString()
        {
            return Name;
        }


    }

}

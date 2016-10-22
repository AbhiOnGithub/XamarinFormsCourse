using System;
using Xamarin.Forms;

namespace LayoutsDemo.LayoutPages
{
	public partial class ColorView : ContentView
	{
		string colorName;
		ColorTypeConverter colorTypeConv = new ColorTypeConverter();


		public ColorView()
		{
			InitializeComponent();
		}


		public string ColorName
		{
			set
			{
				//set the name
				colorName = value;
				colorNameLabel.Text = value;

				//get the actual color and set the other views
				Color color = (Color)colorTypeConv.ConvertFromInvariantString(colorName);
				boxView.Color = color;
				colorValueLabel.Text = $"{(int)(255 * color.R)},{(int)(255 * color.G)},{(int)(255 * color.B)}";
			}
			get
			{
				return colorName;
			}
		}
	}
}

using LayoutsDemo.LayoutPages;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LayoutsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Page> listOfPages = new List<Page>()
            {
                new StackLayoutPage(),
                new GridLayoutPage(),
                new RelativeLayoutPage(),
                new ScrollLayoutPage(),
                new AbsoluteLayoutPage(),
				new HybridLayoutWithChildView()
            };

            listPages.ItemsSource = listOfPages;
            listPages.ItemSelected += ListPages_ItemSelected;

        }


        void ListPages_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                Navigation.PushAsync((Page)e.SelectedItem);
            }
            listPages.SelectedItem = null;
        }
    }
}

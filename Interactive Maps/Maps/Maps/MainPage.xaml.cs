using Microsoft.Maui.Maps;

namespace Maps
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(37.7749, -122.4194), Distance.FromMiles(10)));
        }
    }
}

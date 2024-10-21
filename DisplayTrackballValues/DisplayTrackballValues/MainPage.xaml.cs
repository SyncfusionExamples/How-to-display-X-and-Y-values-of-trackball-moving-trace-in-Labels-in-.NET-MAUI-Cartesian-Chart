using Syncfusion.Maui.Charts;

namespace DisplayTrackballValues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void chart_TrackballCreated(object sender, TrackballEventArgs e)
        {
            listView.ItemsSource = e.TrackballPointsInfo.ToList();
        }
    }

}

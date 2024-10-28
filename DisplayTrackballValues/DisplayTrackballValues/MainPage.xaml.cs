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
            var items = e.TrackballPointsInfo;

            foreach (var item in items)
            {
                var series = item.Series;

                if (series == series1)
                {
                    item.MarkerSettings = new ChartMarkerSettings()
                    {
                        Fill = Colors.DeepSkyBlue,
                        Width = 15,
                        Height = 15,
                        Stroke = Colors.RoyalBlue,
                        StrokeWidth = 3,
                        Type = ShapeType.InvertedTriangle
                    };
                    dateLabel1.SetBinding(Label.TextProperty, new Binding("Date") { Source = item.DataItem, StringFormat = "{0:dd/MM/yyyy}" });
                    valueLabel1.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
                }

                else if (series == series2)
                {
                    item.MarkerSettings = new ChartMarkerSettings()
                    {
                        Fill = Colors.LightPink,
                        Width = 15,
                        Height = 15,
                        Stroke = Colors.HotPink,
                        StrokeWidth = 3,
                        Type = ShapeType.Cross
                    };
                    dateLabel2.SetBinding(Label.TextProperty, new Binding("Date") { Source = item.DataItem, StringFormat = "{0:dd/MM/yyyy}" });
                    valueLabel2.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
                }

                else if (series == series3)
                {
                    item.MarkerSettings = new ChartMarkerSettings()
                    {
                        Fill = Colors.LightSeaGreen,
                        Width = 15,
                        Height = 15,
                        Stroke = Colors.Green,
                        StrokeWidth = 3,
                        Type = ShapeType.Diamond
                    };
                    dateLabel3.SetBinding(Label.TextProperty, new Binding("Date") { Source = item.DataItem, StringFormat = "{0:dd/MM/yyyy}" });
                    valueLabel3.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
                }
            }
        }
    }

}

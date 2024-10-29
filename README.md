# How to display X and Y values of trackball moving trace in Labels in .NET MAUI Cartesian Chart

The [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-charts) allows you to display X and Y values of trackball moving trace in Labels. This can be achieved using the [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) event provided by the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

**Step 1 :** Initialize the SfCartesianChart with [Trackball Behavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html), Create the [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) event, which is triggered when the trackball moves from one data point to another. Refer to the [documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) for detailed steps on initializing the SfCartesianChart.

**[XAML]**
```
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="8*"/>
            <ColumnDefinition Width="2*"/>
        </Grid.ColumnDefinitions>

        <chart:SfCartesianChart x:Name="chart" Grid.Column="0" TrackballCreated="chart_TrackballCreated">

            <chart:SfCartesianChart.XAxes>
                <chart:DateTimeAxis />
            </chart:SfCartesianChart.XAxes>

            <chart:SfCartesianChart.YAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.YAxes>

            <chart:SfCartesianChart.TrackballBehavior>
                <chart:ChartTrackballBehavior ShowLabel="False"/>
            </chart:SfCartesianChart.TrackballBehavior>

            <chart:SfCartesianChart.Legend>
                <chart:ChartLegend/>
            </chart:SfCartesianChart.Legend>

            <chart:LineSeries ItemsSource="{Binding ProductSalesDetails}"
                              x:Name="series1"
                              XBindingPath="Date" 
                              YBindingPath="ProductASales"  
                              StrokeWidth="3"
                              ShowTrackballLabel="True" 
                              Label="Product A"
                              Fill="RoyalBlue"/>
            <chart:LineSeries ItemsSource="{Binding ProductSalesDetails}"
                              x:Name="series2"
                              XBindingPath="Date"
                              YBindingPath="ProductBSales" 
                              StrokeWidth="3"
                              ShowTrackballLabel="True"
                              Label="Product B"
                              Fill="HotPink"/>
            <chart:LineSeries ItemsSource="{Binding ProductSalesDetails}"
                              x:Name="series3"
                              XBindingPath="Date"  
                              YBindingPath="ProductCSales"
                              StrokeWidth="3"
                              ShowTrackballLabel="True"
                              Label="Product C"
                              Fill="Green"/>

        </chart:SfCartesianChart>
</Grid>
    
```
**Step 2 :** Add a `VerticalStackLayout` in `Grid` to display the X and Y values from the [Trackball Behavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html) interaction for each series.

**[XAML]**
```
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="8*"/>
        <ColumnDefinition Width="2*"/>
    </Grid.ColumnDefinitions>

    <chart:SfCartesianChart x:Name="chart" Grid.Column="0" TrackballCreated="chart_TrackballCreated">
        <!-- Chart configuration goes here -->
        . . .
    </chart:SfCartesianChart>

    <VerticalStackLayout Grid.Column="1" HorizontalOptions="Center">
        <!-- Title for trackball values section -->
        <Label HorizontalOptions="Center" Text="Trackball Values" FontAttributes="Bold"/>
        
        <!-- Container for the first series trackball value -->
        <VerticalStackLayout>
            <Frame Background="LightBlue" CornerRadius="8" Margin="5" BorderColor="Gray">
                <HorizontalStackLayout HorizontalOptions="Center" Spacing="10" VerticalOptions="Center">
                    <Label x:Name="dateLabel1"  
                           FontSize="14"
                           FontAttributes="Bold"                    
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label Text=" : "
                           FontSize="14"
                           FontAttributes="Bold"                   
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label x:Name="valueLabel1"  
                           FontSize="14"
                           FontAttributes="Bold"
                           TextColor="Black"
                           VerticalOptions="Center"/>
                </HorizontalStackLayout>
            </Frame>
        </VerticalStackLayout>

        <!-- Container for the second series trackball value -->
        <VerticalStackLayout>
            <Frame Background="Pink" CornerRadius="8" Margin="5" BorderColor="Gray">
                <HorizontalStackLayout HorizontalOptions="Center" Spacing="10" VerticalOptions="Center">
                    <Label x:Name="dateLabel2"  
                           FontSize="14"
                           FontAttributes="Bold"                    
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label Text=" : "
                           FontSize="14"
                           FontAttributes="Bold"                   
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label x:Name="valueLabel2"  
                           FontSize="14"
                           FontAttributes="Bold"
                           TextColor="Black"
                           VerticalOptions="Center"/>
                </HorizontalStackLayout>
            </Frame>
        </VerticalStackLayout>

        <!-- Container for the third series trackball value -->
        <VerticalStackLayout>
            <Frame Background="LightGreen" CornerRadius="8" Margin="5" BorderColor="Gray">
                <HorizontalStackLayout HorizontalOptions="Center" Spacing="10" VerticalOptions="Center">
                    <Label x:Name="dateLabel3"  
                           FontSize="14"
                           FontAttributes="Bold"                    
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label Text=" : "
                           FontSize="14"
                           FontAttributes="Bold"                   
                           TextColor="Black"
                           VerticalOptions="Center"/>
                    <Label x:Name="valueLabel3"  
                           FontSize="14"
                           FontAttributes="Bold"
                           TextColor="Black"
                           VerticalOptions="Center"/>
                </HorizontalStackLayout>
            </Frame>
        </VerticalStackLayout>
    </VerticalStackLayout>
</Grid>

```
**Step 3 :** Finally, handle the [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) event to bind the corresponding date and value labels based on the trackball's position and customize marker settings for each series.

**[C#]**
```
private void chart_TrackballCreated(object sender, TrackballEventArgs e)
{
    // Retrieve the trackball points information
    var items = e.TrackballPointsInfo;

    foreach (var item in items)
    {
        var series = item.Series; 

        if (series == series1)
        {
            // Configure marker settings for the first series
            item.MarkerSettings = new ChartMarkerSettings()
            {
                Fill = Colors.DeepSkyBlue, 
                Width = 15,                
                Height = 15,               
                Stroke = Colors.RoyalBlue, 
                StrokeWidth = 3,           
                Type = ShapeType.InvertedTriangle 
            };

            // Bind the date label to the date from the data item with a specific format
            dateLabel1.SetBinding(Label.TextProperty, new Binding("Date") 
            { 
                Source = item.DataItem, 
                StringFormat = "{0:dd/MM/yyyy}" 
            });

            // Bind the value to the label from the item
            valueLabel1.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
        }
       
        else if (series == series2)
        {
            // Configure marker settings for the second series
            item.MarkerSettings = new ChartMarkerSettings()
            {
                Fill = Colors.LightPink,   
                Width = 15,               
                Height = 15,               
                Stroke = Colors.HotPink,   
                StrokeWidth = 3,           
                Type = ShapeType.Cross      
            };

            // Bind the date label to the date from the data item with a specific format
            dateLabel2.SetBinding(Label.TextProperty, new Binding("Date") 
            { 
                Source = item.DataItem, 
                StringFormat = "{0:dd/MM/yyyy}" 
            });

            // Bind the value to the label from the item
            valueLabel2.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
        }
        
        else if (series == series3)
        {
            // Configure marker settings for the third series
            item.MarkerSettings = new ChartMarkerSettings()
            {
                Fill = Colors.LightSeaGreen, 
                Width = 15,                  
                Height = 15,                 
                Stroke = Colors.Green,       
                StrokeWidth = 3,            
                Type = ShapeType.Diamond     
            };

            // Bind the date label to the date from the data item with a specific format
            dateLabel3.SetBinding(Label.TextProperty, new Binding("Date") 
            { 
                Source = item.DataItem, 
                StringFormat = "{0:dd/MM/yyyy}" 
            });
            
            // Bind the value to the label from the item
            valueLabel3.SetBinding(Label.TextProperty, new Binding("Label") { Source = item });
        }
    }
}
```
This setup allows the  [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) method to manage and display the trackball values dynamically for each series with unique marker styles.

**Output**
 
 ![DisplayTrackballValues.gif](https://support.syncfusion.com/kb/agent/attachment/article/17704/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMxMTg2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.84dybP-P0Y1qPrpa7NiAKXJoddewgrl-Jj-ZXvoG1C8)

## Troubleshooting

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step by step procedure, refer to the [Display trackball values in layout KB article](https://support.syncfusion.com/kb/article/17704/how-to-display-x-and-y-values-of-trackball-moving-trace-in-labels-in-net-maui-cartesian-chart).
# How to display X and Y values of trackball moving trace in Labels in .NET MAUI Cartesian Chart

The [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-charts) allows you to display X and Y values of trackball moving trace in Labels. This can be achieved using the [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) event provided by the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

**Step 1 :** Initialize the SfCartesianChart with [Trackball Behavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html), Create the TrackballCreated event, which is triggered when the trackball moves from one data point to another. Refer to the [documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) for detailed steps on initializing the SfCartesianChart.

**[XAML]**
```
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="8*"/>
            <ColumnDefinition Width="2*"/>
        </Grid.ColumnDefinitions>

        <chart:SfCartesianChart x:Name="chart" Grid.Column="0" TrackballCreated="chart_TrackballCreated">
            
            <chart:SfCartesianChart.XAxes>
                <chart:DateTimeAxis/>
            </chart:SfCartesianChart.XAxes>

            <chart:SfCartesianChart.YAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.YAxes>

            <chart:SfCartesianChart.TrackballBehavior>
                <chart:ChartTrackballBehavior ShowLabel="False"/>
            </chart:SfCartesianChart.TrackballBehavior>

            <chart:LineSeries ItemsSource="{Binding Data}"
                              XBindingPath="Date" 
                              YBindingPath="YValue1"  
                              ShowTrackballLabel="True"  
                              Fill="Pink"/>
                              
            <chart:LineSeries ItemsSource="{Binding Data}"
                              XBindingPath="Date"
                              YBindingPath="YValue2" 
                              ShowTrackballLabel="True"
                              Fill="LightBlue"/>
                              
            <chart:LineSeries ItemsSource="{Binding Data}"
                              XBindingPath="Date"  
                              YBindingPath="YValue3"
                              ShowTrackballLabel="True"
                              Fill="LightGreen"/>

        </chart:SfCartesianChart>
    </Grid>
    
```
**Step 2 :** Add a ListView inside a VerticalStackLayout to display the X and Y values from the trackball interaction.

**[XAML]**
```
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="8*"/>
        <ColumnDefinition Width="2*"/>
    </Grid.ColumnDefinitions>

    <chart:SfCartesianChart x:Name="chart" Grid.Column="0" TrackballCreated="chart_TrackballCreated">
    . . .
    </chart:SfCartesianChart>
    <VerticalStackLayout Grid.Column="1">
        <Label HorizontalOptions="Center" Text="Trackball Values" FontAttributes="Bold"/>
        <ListView x:Name="listView" >
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <Frame Background="{Binding Series.Fill}" CornerRadius="8" Margin="5" BorderColor="Gray">
                            <HorizontalStackLayout HorizontalOptions="Center" Spacing="10" VerticalOptions="Center"  >
                                <Label Text="{Binding DataItem.Date, StringFormat='{0:dd/MM/yyyy}'}"
                                       FontSize="14"
                                       FontAttributes="Bold"                    
                                       TextColor="Black"
                                       VerticalOptions="Center"/>
                                <Label Text=" : "
                                       FontSize="14"
                                       FontAttributes="Bold"                   
                                       TextColor="Black"
                                       VerticalOptions="Center"/>
                                <Label Text="{Binding Label}"
                                       FontSize="14"
                                       FontAttributes="Bold"
                                       TextColor="Black"
                                       VerticalOptions="Center"/>
                            </HorizontalStackLayout>
                        </Frame>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
    </VerticalStackLayout>

</Grid>

```
**Step 3 :** Finally, handle the [TrackballCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated) event to retrieve the trackball data and set it as the ItemsSource for the ListView.

**[C#]**
```
private void chart_TrackballCreated(object sender, TrackballEventArgs e)
{
    // Bind the trackball data to the ListView
    listView.ItemsSource = e.TrackballPointsInfo.ToList();
}
```
This setup allows you to dynamically display the X and Y values from the trackball interaction in a separate view.

**Output**
 ![trackball.gif](https://support.syncfusion.com/kb/agent/attachment/article/17704/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMwODM1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.RUIrwU-Umh4cskkaR_AGXmtujGZkuYRZiMBrzGI-hHU)

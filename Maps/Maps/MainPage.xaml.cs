using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps;

namespace Maps;

public partial class MainPage : ContentPage
{
    private static readonly Location HshlLocation = new(51.6827, 7.8410);
    private static readonly Distance VisibleRadius = Distance.FromKilometers(1);

    public MainPage()
    {
        InitializeComponent();
        ConfigureMap();
    }

    private void ConfigureMap()
    {
        CampusMap.Pins.Add(new Pin
        {
            Label = "HSHL",
            Address = "Hochschule Hamm-Lippstadt",
            Location = HshlLocation,
            Type = PinType.Place
        });

        CenterOnCampus();
    }

    private void OnCenterOnCampusClicked(object? sender, EventArgs e)
    {
        CenterOnCampus();
    }

    private void CenterOnCampus()
    {
        CampusMap.MoveToRegion(MapSpan.FromCenterAndRadius(HshlLocation, VisibleRadius));
    }
}
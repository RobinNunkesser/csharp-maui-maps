# csharp-maui-maps

A minimal teaching example for `Microsoft.Maui.Controls.Maps` in .NET MAUI.

## Learning goal

- register maps support in a MAUI app
- display a map with a fixed region
- add a single pin for a known location
- trigger a small map action from the UI

## What the example shows

- a street map centered on Hochschule Hamm-Lippstadt
- one pin for the campus
- one button that recenters the map

## Key files

- `Maps/Maps/MauiProgram.cs`: enables MAUI maps with `UseMauiMaps()`
- `Maps/Maps/MainPage.xaml`: minimal user interface
- `Maps/Maps/MainPage.xaml.cs`: creates the pin and centers the map

## Scope intentionally kept small

- no GPS permissions
- no user location
- no search
- no routing
- no data binding
# BadgeView
A simple Xamarin.Forms control to display a round badge

Now available on nuget! https://www.nuget.org/packages/BadgeView

## Installation

`Install-Package BadgeView`

## Usage

``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" xmlns:badge="clr-namespace:BadgeView.Shared;assembly=BadgeView.Shared" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" x:Class="BadgeViewExample.BadgePage">
    <ContentPage.Content>
        <StackLayout Orientation="Horizontal" HorizontalOptions="CenterAndExpand" VerticalOptions="Center">
            <Label HorizontalTextAlignment="Center" Text="Look at me!" />
            <badge:BadgeView Text="3" BadgeColor="Green" VerticalOptions="Center" HorizontalOptions="End" />
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

### With Bindings

``` xml
<badge:BadgeView Text="{Binding BadgeNumber}" BadgeColor="{Binding BadgeColor}" VerticalOptions="Center" HorizontalOptions="End" />
```

### Without XAML

``` csharp
var badge = new BadgeView()
{
    Text = "4",
    BadgeColor = Color.Red
};
```

## Additional Resources

Check out my blog post on how to build your own if you want! 
https://alexdunn.org/2017/03/15/xamarin-controls-badgeview/

## TODO

- Add UWP Support

## Sponsor

<a target='_blank' rel='nofollow' href='https://app.codesponsor.io/link/JvDSfZ39KwEWLYqSChESgBc9/SuavePirate/BadgeView'>
  <img alt='Sponsor' width='888' height='68' src='https://app.codesponsor.io/embed/JvDSfZ39KwEWLYqSChESgBc9/SuavePirate/BadgeView.svg' />
</a>


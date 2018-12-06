using System;
using Xamarin.Forms;

namespace BadgeView.Shared
{
    public class CircleView : BoxView
    {
        public static readonly BindableProperty BadgeCornerRadiusProperty = BindableProperty.Create(nameof(BadgeCornerRadius), typeof(double), typeof(CircleView), 0.0);

        public double BadgeCornerRadius
        {
            get { return (double)GetValue(BadgeCornerRadiusProperty); }
            set { SetValue(BadgeCornerRadiusProperty, value); }
        }

    }
}

using System;
using Xamarin.Forms;

namespace BadgeView.Shared
{
    public class CircleView : BoxView
    {
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), typeof(double), typeof(CircleView), 0.0);

        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

       
    }
}

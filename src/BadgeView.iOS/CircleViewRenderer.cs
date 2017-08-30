using System;
using BadgeView.iOS;
using BadgeView.Shared;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleView), typeof(CircleViewRenderer))]
namespace BadgeView.iOS
{
    public class CircleViewRenderer : BoxRenderer
    {
        public static void Initialize(){}
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            Layer.MasksToBounds = true;
            Layer.CornerRadius = (float)((CircleView)Element).CornerRadius / 2.0f;
        }

    }

}

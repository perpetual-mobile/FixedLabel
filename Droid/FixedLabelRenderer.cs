using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Demo.Droid;

[assembly:ExportRenderer(typeof(global::FixedLabel.FixedLabel), typeof(FixedLabelRenderer))]

namespace Demo.Droid
{
    public class FixedLabelRenderer: ViewRenderer
    {
        public override SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
        {
            Console.WriteLine("GetDesiredSize");
            return new SizeRequest(new Size(10, 50));
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            Console.WriteLine("OnSizeChanged");
        }

        public override void Invalidate()
        {
            Console.WriteLine("Invalidate");
        }
    }
}


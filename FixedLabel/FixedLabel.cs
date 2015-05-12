using Xamarin.Forms;

namespace FixedLabel
{
    public class FixedLabel: View
    {
        public FixedLabel()
        {
        }

        protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
        {
            return new SizeRequest(new Size(10, 50));
        }

        public override SizeRequest GetSizeRequest(double widthConstraint, double heightConstraint)
        {
            return new SizeRequest(new Size(10, 50));
        }

        protected override void InvalidateMeasure()
        {
//            base.InvalidateMeasure();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
//            base.OnSizeAllocated(width, height);
        }
    }
}


using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Demo
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new ContentPage {
                Content = new StackLayout {
                    Children = {
                        new NavigationButton(1),
                        new NavigationButton(10),
                        new NavigationButton(100),
                    },
                },
            });
        }
    }

    public class NavigationButton: Button
    {
        public NavigationButton(int number)
        {
            Text = number + " Label(s)";
            Command = new Command(o => {
                LabelPage.StartTime = DateTime.Now;
                Application.Current.MainPage.Navigation.PushAsync(new LabelPage(number));
            });
        }
    }

    public class LabelPage: ContentPage
    {
        public static DateTime StartTime;

        public LabelPage(int number)
        {
            var stack = new MyStack {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };
            for (var i = 0; i < number; i++)
                stack.Children.Add(new FixedLabel.FixedLabel {
                    BackgroundColor = Color.Red,
                    HeightRequest = 20,
                    WidthRequest = 50,
                    MinimumHeightRequest = 20,
                    MinimumWidthRequest = 20,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Start,
                });
            Content = new ScrollView{ Content = stack };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = (DateTime.Now - StartTime).TotalMilliseconds + " ms";
        }
    }

    class MyStack : Layout<View>
    {
        protected override void LayoutChildren(double x, double y, double width, double height)
        {
//            throw new NotImplementedException();
        }

        protected override bool ShouldInvalidateOnChildAdded(View child)
        {
            return false;
        }

        protected override bool ShouldInvalidateOnChildRemoved(View child)
        {
            return false;
        }

        protected override void OnChildMeasureInvalidated()
        {
//            base.OnChildMeasureInvalidated();
        }

        protected override void OnChildAdded(Element child)
        {
//            base.OnChildAdded(child);
        }

        protected override void InvalidateLayout()
        {
//            base.InvalidateLayout();
        }

        protected override void InvalidateMeasure()
        {
//            base.InvalidateMeasure();
        }
    }
}


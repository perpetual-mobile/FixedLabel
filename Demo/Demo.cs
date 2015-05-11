using System;
using Xamarin.Forms;

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
            Text = number + " Label";
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
            var stack = new StackLayout { VerticalOptions = LayoutOptions.Center };
            for (var i = 0; i < number; i++)
                stack.Children.Add(new Label { Text = "Label " + i });
            Content = new ScrollView{ Content = stack };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = (DateTime.Now - StartTime).TotalMilliseconds + " ms";
        }
    }
}


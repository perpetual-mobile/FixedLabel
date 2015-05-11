using Xamarin.Forms;

namespace Demo
{
    public class App : Application
    {
        public App()
        {
            var stack = new StackLayout { VerticalOptions = LayoutOptions.Center };
            for (var i = 0; i < 40; i++)
                stack.Children.Add(new Label { Text = "Label " + i });

            MainPage = new ContentPage {
                Padding = new Thickness(0, Device.OS == TargetPlatform.iOS ? 20 : 0, 0, 0),
                Content = new ScrollView{ Content = stack },
            };
        }
    }
}


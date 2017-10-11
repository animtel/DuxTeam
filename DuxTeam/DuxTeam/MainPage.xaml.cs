using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DuxTeam
{
	public partial class MainPage : ContentPage
	{
        Label label = new Label
        {
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center,
            Text = "TIME!",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
        };
        public MainPage()
		{
			InitializeComponent();

            StackLayout stackLayout = new StackLayout();

            Button button = new Button
            {
                Text = "Нажми!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            
            button.Clicked += OnButtonClicked;
            stackLayout.Children.Add(button);
            stackLayout.Children.Add(label);

            this.Content = stackLayout;
        }
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string test = DateTime.Now.ToString();
            label.Text = test;
            
        }
    }
}

using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Android.Content;

namespace App2
{
	public partial class MainPage : ContentPage
	{
        private Context context;

        public MainPage()
		{
			//InitializeComponent();
            var layout = new StackLayout();
            var button = new Xamarin.Forms.Button
            {
                Text = "Hallo, presiona el button, please.",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            button.Clicked += Button_Clicked;
            var label = new Label { Text = "Привет!" };
            this.Content = layout;
            layout.Children.Add(label);
            layout.Children.Add(button);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Y juntos pasaar yo los veo", "Y paasan cerca de mii", "Yo sé que es toonto mi llantoo", "Que es tonto que hoy llore por ééél");

        }
    }
}

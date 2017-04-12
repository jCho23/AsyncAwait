using System;
using System.Net.Http;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace AsyncAwait
{
	class MyPage : ContentPage
	{
		private Button asyncButton = new Button { Text = "Click" };
		private Label resultsLabel = new Label();

		public MyPage()
		{//constructors are where you set EVERYTHING up

			asyncButton.Clicked += AsyncButton_Clicked;

			asyncButton.Clicked += (sender, e) =>
			{


			};

			//Every object has a reference that has methods and properties 
			//Event handlers ALWAYS has +=
			Content = new StackLayout
			{

				Children = {
					asyncButton,
					resultsLabel,

				}
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();


		}

		async void AsyncButton_Clicked(object sender, EventArgs e)
		//void only used in Event Handlers for Async operations
		{
			using (var client = new HttpClient())
			{
				var results = await client.GetStringAsync("https://itunes.apple.com/search?term=jack+johnson");
				//return type is ALWAYS before the method name
				//Almost always use Task
				//Task<t> is used to return a value
				//Whenever the method is returning a task or task<t> you always put "await" infront of the method


				Device.BeginInvokeOnMainThread(() => resultsLabel.Text = results);


			}
		}
	}
}


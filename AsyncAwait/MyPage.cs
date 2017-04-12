using System;

using Xamarin.Forms;

namespace AsyncAwait
{
	class MyPage : ContentPage
	{
		private Button asyncButton = new Button { Text = "Click" };
		private Label resultsLabel = new Label();

		public MyPage()
		{//constructors are where you set EVERYTHING up
			Content = new StackLayout
			{

				Children = {
					asyncButton,
					resultsLabel,

				}
			};
		}
	}
}


using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			Init();
		}

		void Init()
		{ 
			
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new RegisteredPage());
			//make the link with the button connect to Regisreredpage
		}
	}
}
